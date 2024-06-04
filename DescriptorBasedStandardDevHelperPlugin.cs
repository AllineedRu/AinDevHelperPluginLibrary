using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using AinDevHelperPluginLibrary.Descriptor;
using AinDevHelperPluginLibrary.Actions;
using AinDevHelperPluginLibrary.Actions.Parameters;

namespace AinDevHelperPluginLibrary {
    /// <summary>
    /// [RU] Класс описывает плагины, основанные на дескрипторе (XML-файл 'plugin_descriptor.xml' в каталоге /plugins/[PluginName]/).
    /// [EN] The class describes plugins based on a descriptor (XML file 'plugin_descriptor.xml' in the /plugins/[PluginName]/ directory).
    /// </summary>
    public class DescriptorBasedStandardDevHelperPlugin : StandardAinDevHelperPlugin {
        private const string PLUGIN_DIR_VAR = "$PLUGIN_DIR$";
        private const string PROCESS_EXIT_CODE_VAR = "$PROCESS_EXIT_CODE$";
        private const string PLUGIN_ACTION_NAME_VAR = "$PLUGIN_ACTION_NAME$";
        private const string PLUGIN_ACTION_WEB_LINK_VAR = "$PLUGIN_ACTION_WEB_LINK$";

        public const string PLUGIN_DESCRIPTOR_FILE_NAME = "plugin_descriptor.xml";

        public AinDevHelperPluginDescriptor PluginDescriptor { get; set; }
        public override string Name => PluginDescriptor.Name;
        public override string Company => PluginDescriptor.Company;
        public override string Description => PluginDescriptor.Description;
        public override string Author => PluginDescriptor.Author;
        public override int MajorVersion => PluginDescriptor.MajorVersion;
        public override int MinorVersion => PluginDescriptor.MinorVersion;
        public override int BuildVersion => PluginDescriptor.BuildVersion;
        public override int RevisionVersion => PluginDescriptor.RevisionVersion;
        public override string AuthorSiteURL => PluginDescriptor.AuthorSiteURL;
        public override IEnumerable<string> Tags => PluginDescriptor.Tags;
        public override IEnumerable<string> SupportedLanguageCodes => PluginDescriptor.SupportedLanguageCodes;

        public DescriptorBasedStandardDevHelperPlugin(AinDevHelperPluginDescriptor pluginDescriptor) {
            if (pluginDescriptor == null) {
                throw new ArgumentNullException("pluginDescriptor", "Параметр не может быть равен null");
            }
            PluginDescriptor = pluginDescriptor;
        }

        public override IEnumerable<AinDevHelperPluginAction> GetActions() {
            List<AinDevHelperPluginAction> pluginActions = new List<AinDevHelperPluginAction>();
            if (PluginDescriptor.Actions != null && PluginDescriptor.Actions.Count > 0) {
                foreach (AinDevHelperPluginActionDescriptor actionDescriptor in PluginDescriptor.Actions) {
                    if (actionDescriptor is AinDevHelperPluginWebLinkActionDescriptor webLinkActionDescriptor) {
                        AinDevHelperPluginWebLinkAction webLinkAction = new AinDevHelperPluginWebLinkAction(webLinkActionDescriptor);
                        pluginActions.Add(webLinkAction);
                    } else if (actionDescriptor is AinDevHelperPluginParameterizedActionDescriptor parameterizedActionDescriptor) {                        
                        AinDevHelperPluginParameterizedAction parameterizedAction = new AinDevHelperPluginParameterizedAction(parameterizedActionDescriptor);
                        pluginActions.Add(parameterizedAction);
                    } else if (actionDescriptor is AinDevHelperPluginNoParamsActionDescriptor noParamsActionDescriptor) {
                        AinDevHelperPluginAction noParamsPluginAction = new AinDevHelperPluginAction(noParamsActionDescriptor);
                        pluginActions.Add(noParamsPluginAction);
                    }
                    else {
                        //TODO: резерв под будущие типы параметров для действия плагина. Реализовать другие ветки при появлении новых типов
                    }
                }
            }            
            return pluginActions;
        }

        public virtual List<string> GetReplacedSubstitutionParameters(List<string> substitutionParameters, Dictionary<string, string> substitutionParametersReplacements) {
            List<string> finalSubstitutionParameters = new List<string>();
            foreach (string substitutionParam in substitutionParameters) {
                string finalParam = substitutionParam;
                foreach (var replacement in substitutionParametersReplacements) {
                    finalParam = finalParam.Replace(replacement.Key, replacement.Value);
                }
                finalSubstitutionParameters.Add(finalParam);
            }
            return finalSubstitutionParameters;
        }


        public virtual AinDevHelperPluginActionResult RunParameterizedActionKindRunProcess(
                AinDevHelperPluginParameterizedAction parameterizedAction, 
                AinDevHelperPluginParameterizedActionDescriptor parameterizedActionDescriptor, 
                AinDevHelperPerformedActionKindRunProcess actionKindRunProcess) {
            string commandToRun = actionKindRunProcess.Command;
            string argumentsForCommand = actionKindRunProcess.Arguments;

            int processExitCode;

            Dictionary<string, string> substitutionParamsReplacementDict = new Dictionary<string, string> {
                        { PLUGIN_ACTION_NAME_VAR, parameterizedAction.Name }                        
                    };

            foreach (var parameter in parameterizedAction.Parameters) {
                if (parameter is AinDevHelperPluginActionTextParameter textParameter) {
                    substitutionParamsReplacementDict.Add("$" + parameter.Name + "$", textParameter.Text);
                } else if (parameter is AinDevHelperPluginActionDirectorySelectionParameter directorySelectionParameter) {
                    substitutionParamsReplacementDict.Add("$" + directorySelectionParameter.Name + "$", directorySelectionParameter.SelectedDirectory);
                } else if (parameter is AinDevHelperPluginActionFileSelectionParameter fileSelectionParameter) {
                    substitutionParamsReplacementDict.Add("$" + fileSelectionParameter.Name + "$", fileSelectionParameter.SelectedFile);
                } else if (parameter is AinDevHelperPluginActionCheckBoxParameter checkBoxParameter) {
                    substitutionParamsReplacementDict.Add("$" + checkBoxParameter.Name + "$", checkBoxParameter.Checked.ToString());
                }
            }


            if (actionKindRunProcess.SubstitutionParameters != null && actionKindRunProcess.SubstitutionParameters.Count > 0) {
                //if (!string.IsNullOrEmpty(actionKindRunProcess.WorkingDirectory)) {

                    string workingDirectory = string.IsNullOrEmpty(actionKindRunProcess.WorkingDirectory) || 
                        PLUGIN_DIR_VAR.Equals(actionKindRunProcess.WorkingDirectory) ? PluginDirectory : actionKindRunProcess.WorkingDirectory;

                    List<string> replacedSubstitutionParameters = GetReplacedSubstitutionParameters(actionKindRunProcess.SubstitutionParameters, substitutionParamsReplacementDict);
                    processExitCode = AinCommandLineHelper.RunProcessWithWindow(
                        workingDirectory,
                        commandToRun,
                        string.Format(argumentsForCommand, replacedSubstitutionParameters.ToArray())
                    );
                //} else {
                    //List<string> replacedSubstitutionParameters = GetReplacedSubstitutionParameters(actionKindRunProcess.SubstitutionParameters, substitutionParamsReplacementDict);
                    //processExitCode = AinCommandLineHelper.RunProcessWithWindow(
                    //    commandToRun,
                    //    string.Format(argumentsForCommand, replacedSubstitutionParameters.ToArray())
                    //);
                //}

                //TODO: add validations?
                //RecentTauriAppName ??= Path.GetFileName(targetDirectory);
            } else {
                //if (!string.IsNullOrEmpty(actionKindRunProcess.WorkingDirectory)) {
                    string workingDirectory = string.IsNullOrEmpty(actionKindRunProcess.WorkingDirectory) ||
                        PLUGIN_DIR_VAR.Equals(actionKindRunProcess.WorkingDirectory) ? PluginDirectory : actionKindRunProcess.WorkingDirectory;

                    processExitCode = AinCommandLineHelper.RunProcessWithWindow(
                        workingDirectory,
                        commandToRun,
                        argumentsForCommand
                    );
                //} else {
                    //processExitCode = AinCommandLineHelper.RunProcessWithWindow(
                    //    commandToRun,
                    //    argumentsForCommand
                    //);
                //}
            }

            substitutionParamsReplacementDict.Add(PROCESS_EXIT_CODE_VAR, processExitCode.ToString());

            if (processExitCode == 0) {
                if (parameterizedActionDescriptor.SuccessMessage != null) {
                    if (parameterizedActionDescriptor.SuccessMessage.SubstitutionParameters != null) {
                        List<string> replacedSubstitutionParameters = GetReplacedSubstitutionParameters(parameterizedActionDescriptor.SuccessMessage.SubstitutionParameters, substitutionParamsReplacementDict);
                        string finalSuccessMessage = string.Format(parameterizedActionDescriptor.SuccessMessage.Message, replacedSubstitutionParameters.ToArray());
                        return new AinDevHelperPluginActionResult(this, parameterizedAction, finalSuccessMessage, true);
                    } else {
                        return new AinDevHelperPluginActionResult(this, parameterizedAction, parameterizedActionDescriptor.SuccessMessage.Message, true);
                    }                    
                } else {
                    return new AinDevHelperPluginActionResult(this, parameterizedAction, $"Действие '{parameterizedAction.Name}' выполнено успешно.", false);
                }                
            } else {
                if (parameterizedActionDescriptor.ErrorMessage != null) {
                    if (parameterizedActionDescriptor.ErrorMessage.SubstitutionParameters != null) {
                        List<string> replacedSubstitutionParameters = GetReplacedSubstitutionParameters(parameterizedActionDescriptor.ErrorMessage.SubstitutionParameters, substitutionParamsReplacementDict);
                        string finalErrorMessage = string.Format(parameterizedActionDescriptor.ErrorMessage.Message, replacedSubstitutionParameters.ToArray());
                        return new AinDevHelperPluginActionResult(this, parameterizedAction, finalErrorMessage, true);
                    } else {
                        return new AinDevHelperPluginActionResult(this, parameterizedAction, parameterizedActionDescriptor.ErrorMessage.Message, true);
                    }                    
                } else {
                    return new AinDevHelperPluginActionResult(this, parameterizedAction, $"Действие '{parameterizedAction.Name}' выполнено неуспешно (код завершения процесса: {processExitCode}).", true);
                }                
            }
        }

        public virtual AinDevHelperPluginActionResult RunParameterizedAction(AinDevHelperPluginParameterizedAction parameterizedAction) {
            var pluginActionDescriptor = GetPluginActionDescriptorByActionName(parameterizedAction.Name);
            
            if (pluginActionDescriptor is AinDevHelperPluginParameterizedActionDescriptor parameterizedActionDescriptor) {
                var performedActionKind = parameterizedActionDescriptor.PerformedActionKind;
                if (performedActionKind is AinDevHelperPerformedActionKindRunProcess actionKindRunProcess) {
                    return RunParameterizedActionKindRunProcess(parameterizedAction, parameterizedActionDescriptor, actionKindRunProcess);
                }
            }
            
            return GetErroneousResponse(parameterizedAction, "Ошибка при выполнении действия плагина. Действие не распознано.");
        }

        public virtual AinDevHelperPluginActionResult RunNoParamsAction(AinDevHelperPluginAction noParamsAction) {
            var pluginActionDescriptor = GetPluginActionDescriptorByActionName(noParamsAction.Name);

            if (pluginActionDescriptor is AinDevHelperPluginNoParamsActionDescriptor noParamsActionDescriptor) {
                var performedActionKind = noParamsActionDescriptor.PerformedActionKind;
                if (performedActionKind is AinDevHelperPerformedActionKindRunProcess actionKindRunProcess) {
                    return RunNoParamsActionKindRunProcess(noParamsAction, noParamsActionDescriptor, actionKindRunProcess);
                }
            }

            return GetErroneousResponse(noParamsAction, "Ошибка при выполнении действия плагина. Действие не распознано.");
        }

        private AinDevHelperPluginActionResult RunNoParamsActionKindRunProcess(AinDevHelperPluginAction noParamsAction, AinDevHelperPluginNoParamsActionDescriptor noParamsActionDescriptor, AinDevHelperPerformedActionKindRunProcess actionKindRunProcess) {
            string commandToRun = actionKindRunProcess.Command;
            string argumentsForCommand = actionKindRunProcess.Arguments;

            int processExitCode;

            Dictionary<string, string> substitutionParamsReplacementDict = new Dictionary<string, string> {
                        { PLUGIN_ACTION_NAME_VAR, noParamsAction.Name }
                    };

            if (actionKindRunProcess.SubstitutionParameters != null && actionKindRunProcess.SubstitutionParameters.Count > 0) {
                //if (!string.IsNullOrEmpty(actionKindRunProcess.WorkingDirectory)) {
                    List<string> replacedSubstitutionParameters = GetReplacedSubstitutionParameters(actionKindRunProcess.SubstitutionParameters, substitutionParamsReplacementDict);

                    string workingDirectory = string.IsNullOrEmpty(actionKindRunProcess.WorkingDirectory) || 
                        PLUGIN_DIR_VAR.Equals(actionKindRunProcess.WorkingDirectory) ? PluginDirectory : actionKindRunProcess.WorkingDirectory;

                    if (actionKindRunProcess.ShowProcessWindow) {
                        if (actionKindRunProcess.RedirectToFile && !string.IsNullOrEmpty(actionKindRunProcess.RedirectToFileName)) {
                            processExitCode = AinCommandLineHelper.RunProcessWithWindow(
                                workingDirectory,
                                commandToRun,
                                string.Format(argumentsForCommand, replacedSubstitutionParameters.ToArray()) + " > " + actionKindRunProcess.RedirectToFileName
                            );
                        } else {
                            processExitCode = AinCommandLineHelper.RunProcessWithWindow(
                                workingDirectory,
                                commandToRun,
                                string.Format(argumentsForCommand, replacedSubstitutionParameters.ToArray())
                            );
                        }
                    } else {
                        if (actionKindRunProcess.RedirectToFile && !string.IsNullOrEmpty(actionKindRunProcess.RedirectToFileName)) {
                            processExitCode = AinCommandLineHelper.RunProcessWithoutWindow(
                                workingDirectory,
                                commandToRun,
                                string.Format(argumentsForCommand, replacedSubstitutionParameters.ToArray()) + " > " + actionKindRunProcess.RedirectToFileName
                            );
                        } else {
                            processExitCode = AinCommandLineHelper.RunProcessWithoutWindow(
                                workingDirectory,
                                commandToRun,
                                string.Format(argumentsForCommand, replacedSubstitutionParameters.ToArray())
                            );
                        }
                    }


                //} else {
                    //List<string> replacedSubstitutionParameters = GetReplacedSubstitutionParameters(actionKindRunProcess.SubstitutionParameters, substitutionParamsReplacementDict);
                    //processExitCode = AinCommandLineHelper.RunProcessWithWindow(
                    //    commandToRun,
                    //    string.Format(argumentsForCommand, replacedSubstitutionParameters.ToArray())
                    //);
                //}
            } else {
                //if (!string.IsNullOrEmpty(actionKindRunProcess.WorkingDirectory)) {
                    string workingDirectory = string.IsNullOrEmpty(actionKindRunProcess.WorkingDirectory) || 
                        PLUGIN_DIR_VAR.Equals(actionKindRunProcess.WorkingDirectory) ? PluginDirectory : actionKindRunProcess.WorkingDirectory;

                    if (actionKindRunProcess.ShowProcessWindow) {
                        if (actionKindRunProcess.RedirectToFile && !string.IsNullOrEmpty(actionKindRunProcess.RedirectToFileName)) {
                            processExitCode = AinCommandLineHelper.RunProcessWithWindow(
                                workingDirectory,
                                commandToRun,
                                argumentsForCommand + " > " + actionKindRunProcess.RedirectToFileName
                            );
                        } else {
                            processExitCode = AinCommandLineHelper.RunProcessWithWindow(
                                workingDirectory,
                                commandToRun,
                                argumentsForCommand
                            );
                        }                        
                    } else {
                        if (actionKindRunProcess.RedirectToFile && !string.IsNullOrEmpty(actionKindRunProcess.RedirectToFileName)) {
                            processExitCode = AinCommandLineHelper.RunProcessWithoutWindow(
                                workingDirectory,
                                commandToRun,
                                argumentsForCommand + " > " + actionKindRunProcess.RedirectToFileName
                            );
                        } else {
                            processExitCode = AinCommandLineHelper.RunProcessWithoutWindow(
                                workingDirectory,
                                commandToRun,
                                argumentsForCommand
                            );
                        }                            
                    }
                //} else {
                //    if (actionKindRunProcess.ShowProcessWindow) {
                //        if (actionKindRunProcess.RedirectToFile && !string.IsNullOrEmpty(actionKindRunProcess.RedirectToFileName)) {
                //            processExitCode = AinCommandLineHelper.RunProcessWithWindow(
                //                commandToRun,
                //                argumentsForCommand + " > " + actionKindRunProcess.RedirectToFileName
                //            );
                //        } else {
                //            processExitCode = AinCommandLineHelper.RunProcessWithWindow(
                //                commandToRun,
                //                argumentsForCommand
                //            );
                //        }
                //    } else {
                //        if (actionKindRunProcess.RedirectToFile && !string.IsNullOrEmpty(actionKindRunProcess.RedirectToFileName)) {
                //            processExitCode = AinCommandLineHelper.RunProcessWithoutWindow(
                //                commandToRun,
                //                argumentsForCommand + " > " + actionKindRunProcess.RedirectToFileName
                //            );
                //        } else {
                //            processExitCode = AinCommandLineHelper.RunProcessWithoutWindow(
                //                commandToRun,
                //                argumentsForCommand
                //            );
                //        }
                //    }                    
                //}
            }

            substitutionParamsReplacementDict.Add(PROCESS_EXIT_CODE_VAR, processExitCode.ToString());

            if (processExitCode == 0) {
                if (noParamsActionDescriptor.SuccessMessage != null) {
                    if (noParamsActionDescriptor.SuccessMessage.SubstitutionParameters != null) {
                        List<string> replacedSubstitutionParameters = GetReplacedSubstitutionParameters(noParamsActionDescriptor.SuccessMessage.SubstitutionParameters, substitutionParamsReplacementDict);
                        string finalSuccessMessage = string.Format(noParamsActionDescriptor.SuccessMessage.Message, replacedSubstitutionParameters.ToArray());

                        if (actionKindRunProcess.RedirectToFile && !string.IsNullOrEmpty(actionKindRunProcess.RedirectToFileName)) {

                            string redirectFilePath = string.IsNullOrEmpty(actionKindRunProcess.WorkingDirectory) || PLUGIN_DIR_VAR.Equals(actionKindRunProcess.WorkingDirectory)
                                ? PluginDirectory + Path.DirectorySeparatorChar + actionKindRunProcess.RedirectToFileName
                                : actionKindRunProcess.RedirectToFileName;

                            if (File.Exists(redirectFilePath)) {
                                string commandOutput = File.ReadAllText(redirectFilePath);
                                Console.WriteLine(commandOutput);
                                commandOutput = commandOutput.Replace("\n", "\r\n");

                                finalSuccessMessage += "\r\n\r\n" + commandOutput;

                                return new AinDevHelperPluginActionResult(this, noParamsAction, finalSuccessMessage);
                            }
                            return new AinDevHelperPluginActionResult(this, noParamsAction, finalSuccessMessage, true);
                        } else {
                            return new AinDevHelperPluginActionResult(this, noParamsAction, finalSuccessMessage, true);
                        }
                    } else {
                        return new AinDevHelperPluginActionResult(this, noParamsAction, noParamsActionDescriptor.SuccessMessage.Message, true);
                    }
                } else {
                    if (actionKindRunProcess.RedirectToFile && !string.IsNullOrEmpty(actionKindRunProcess.RedirectToFileName)) {

                        string redirectFilePath = string.IsNullOrEmpty(actionKindRunProcess.WorkingDirectory) || PLUGIN_DIR_VAR.Equals(actionKindRunProcess.WorkingDirectory) 
                            ? PluginDirectory + Path.DirectorySeparatorChar + actionKindRunProcess.RedirectToFileName 
                            : actionKindRunProcess.RedirectToFileName;

                        if (File.Exists(redirectFilePath)) {
                            string commandOutput = File.ReadAllText(redirectFilePath);
                            Console.WriteLine(commandOutput);
                            commandOutput = commandOutput.Replace("\n", "\r\n");                           
                            return new AinDevHelperPluginActionResult(this, noParamsAction, $"Действие '{noParamsAction.Name}' выполнено успешно.\r\n\r\n{commandOutput}");
                        }                        
                    }
                    return new AinDevHelperPluginActionResult(this, noParamsAction, $"Действие '{noParamsAction.Name}' выполнено успешно.", false);

                }
            } else {
                if (noParamsActionDescriptor.ErrorMessage != null) {
                    if (noParamsActionDescriptor.ErrorMessage.SubstitutionParameters != null) {
                        List<string> replacedSubstitutionParameters = GetReplacedSubstitutionParameters(noParamsActionDescriptor.ErrorMessage.SubstitutionParameters, substitutionParamsReplacementDict);
                        string finalErrorMessage = string.Format(noParamsActionDescriptor.ErrorMessage.Message, replacedSubstitutionParameters.ToArray());
                        return new AinDevHelperPluginActionResult(this, noParamsAction, finalErrorMessage, true);
                    } else {
                        return new AinDevHelperPluginActionResult(this, noParamsAction, noParamsActionDescriptor.ErrorMessage.Message, true);
                    }
                } else {
                    return new AinDevHelperPluginActionResult(this, noParamsAction, $"Действие '{noParamsAction.Name}' выполнено неуспешно (код завершения процесса: {processExitCode}).", true);
                }
            }
        }

        public virtual AinDevHelperPluginActionDescriptor GetPluginActionDescriptorByActionName(string actionName) {
            foreach (var pluginActionDescriptor in PluginDescriptor.Actions) {
                if (pluginActionDescriptor.Name.Equals(actionName)) {
                    return pluginActionDescriptor;
                }
            }
            return null;
        }

        public override AinDevHelperPluginActionResult RunAction(AinDevHelperPluginAction actionToRun) {
            if (actionToRun is AinDevHelperPluginWebLinkAction webLinkAction) {
                Process proc = Process.Start(webLinkAction.WebLink);
                if (proc != null) {
                    proc.WaitForExit();

                    var pluginActionDescriptor = GetPluginActionDescriptorByActionName(actionToRun.Name);

                    Dictionary<string, string> substitutionParamsReplacementDict = new Dictionary<string, string> {
                        { PLUGIN_ACTION_NAME_VAR, actionToRun.Name },
                        { PROCESS_EXIT_CODE_VAR, proc.ExitCode.ToString() }
                    };


                    if (proc.ExitCode == 0) {
                        if (pluginActionDescriptor is AinDevHelperPluginWebLinkActionDescriptor webLinkActionDescriptor && webLinkActionDescriptor.SuccessMessage != null && webLinkActionDescriptor.SuccessMessage.Message != null) {
                            if (webLinkActionDescriptor.SuccessMessage.SubstitutionParameters != null) {

                                substitutionParamsReplacementDict.Add(PLUGIN_ACTION_WEB_LINK_VAR, webLinkActionDescriptor.WebLink);

                                List<string> replacedSubstitutionParameters = GetReplacedSubstitutionParameters(webLinkActionDescriptor.SuccessMessage.SubstitutionParameters, substitutionParamsReplacementDict);
                                string finalSuccessMessage = string.Format(webLinkActionDescriptor.SuccessMessage.Message, replacedSubstitutionParameters.ToArray());
                                return new AinDevHelperPluginActionResult(this, actionToRun, finalSuccessMessage, false);
                            } else {
                                return new AinDevHelperPluginActionResult(this, actionToRun, webLinkActionDescriptor.SuccessMessage.Message, false);
                            }                            
                        } else {
                            return new AinDevHelperPluginActionResult(this, actionToRun, $"Действие '{actionToRun.Name}' выполнено успешно.", false);
                        }
                    } else {
                        if (pluginActionDescriptor is AinDevHelperPluginWebLinkActionDescriptor webLinkActionDescriptor && webLinkActionDescriptor.ErrorMessage != null && webLinkActionDescriptor.ErrorMessage.Message != null) {
                            if (webLinkActionDescriptor.ErrorMessage.SubstitutionParameters != null) {
                                List<string> replacedSubstitutionParameters = GetReplacedSubstitutionParameters(webLinkActionDescriptor.ErrorMessage.SubstitutionParameters, substitutionParamsReplacementDict);
                                string finalErrorMessage = string.Format(webLinkActionDescriptor.ErrorMessage.Message, replacedSubstitutionParameters.ToArray());
                                return new AinDevHelperPluginActionResult(this, actionToRun, finalErrorMessage, false);
                            } else {
                                return new AinDevHelperPluginActionResult(this, actionToRun, webLinkActionDescriptor.ErrorMessage.Message, false);
                            }
                        } else {
                            return new AinDevHelperPluginActionResult(this, actionToRun, $"Действие '{actionToRun.Name}' выполнено неуспешно (код завершения процесса: {proc.ExitCode}).", false);
                        }
                    }                    
                }
            } else if (actionToRun is AinDevHelperPluginParameterizedAction parameterizedAction) {
                return RunParameterizedAction(parameterizedAction);
            } else if (actionToRun is AinDevHelperPluginAction noParamsAction) {
                return RunNoParamsAction(noParamsAction);
            }

            if (actionToRun != null) {
                return GetErroneousResponse(actionToRun, $"Ошибка при выполнении действия плагина. Действие '{actionToRun.Name}' не распознано.");
            } else {
                return GetErroneousResponse(actionToRun, "Ошибка при выполнении действия плагина. Действие не распознано.");
            }            
        }
    }
}
