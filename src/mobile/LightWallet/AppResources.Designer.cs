﻿// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Etherify.LightWallet {
    using System;
    using System.Reflection;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class AppResources {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AppResources() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("Etherify.LightWallet.AppResources", typeof(AppResources).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        public static string FirstAccessPage_Title {
            get {
                return ResourceManager.GetString("FirstAccessPage_Title", resourceCulture);
            }
        }
        
        public static string FirstAccessPage_Subtitle {
            get {
                return ResourceManager.GetString("FirstAccessPage_Subtitle", resourceCulture);
            }
        }
        
        public static string FirstAccessPage_ButtonCreateNewWallet {
            get {
                return ResourceManager.GetString("FirstAccessPage_ButtonCreateNewWallet", resourceCulture);
            }
        }
        
        public static string FirstAccessPage_ButtonRecoveryMyWallet {
            get {
                return ResourceManager.GetString("FirstAccessPage_ButtonRecoveryMyWallet", resourceCulture);
            }
        }
        
        public static string FirstAccessPage_ButtonOpenTermsOfService {
            get {
                return ResourceManager.GetString("FirstAccessPage_ButtonOpenTermsOfService", resourceCulture);
            }
        }
        
        public static string FirstAccessPage_ButtonOpenGithub {
            get {
                return ResourceManager.GetString("FirstAccessPage_ButtonOpenGithub", resourceCulture);
            }
        }
        
        public static string CreateNewWalletPage_Title {
            get {
                return ResourceManager.GetString("CreateNewWalletPage_Title", resourceCulture);
            }
        }
        
        public static string CreateNewWalletPage_Description {
            get {
                return ResourceManager.GetString("CreateNewWalletPage_Description", resourceCulture);
            }
        }
        
        public static string CreateNewWalletPage_Passphrase {
            get {
                return ResourceManager.GetString("CreateNewWalletPage_Passphrase", resourceCulture);
            }
        }
        
        public static string CreateNewWalletPage_ConfirmPassphrase {
            get {
                return ResourceManager.GetString("CreateNewWalletPage_ConfirmPassphrase", resourceCulture);
            }
        }
        
        public static string CreateNewWalletPage_Next {
            get {
                return ResourceManager.GetString("CreateNewWalletPage_Next", resourceCulture);
            }
        }
        
        public static string Button_SearchForExistentAccounts {
            get {
                return ResourceManager.GetString("Button_SearchForExistentAccounts", resourceCulture);
            }
        }
    }
}
