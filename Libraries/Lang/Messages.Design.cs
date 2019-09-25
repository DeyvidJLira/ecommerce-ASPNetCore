namespace ecommerce_aspnet.Libraries.Lang {
    using System;
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ecommerce_aspnet.Libraries.Lang.Messages", typeof(Messages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        internal static string MSG_E001 {
            get {
                return ResourceManager.GetString("MSG_E001", resourceCulture);
            }
        }

        internal static string MSG_E002 {
            get {
                return ResourceManager.GetString("MSG_E002", resourceCulture);
            }
        }

        internal static string MSG_E003 {
            get {
                return ResourceManager.GetString("MSG_E003", resourceCulture);
            }
        }

        internal static string MSG_E004 {
            get {
                return ResourceManager.GetString("MSG_E004", resourceCulture);
            }
        }
        
     
    }
}