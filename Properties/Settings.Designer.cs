﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MSB_PTBVIP23.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.13.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=Immagorst\\MSSQLSERVER01;Initial Catalog=QuanLyMusicBoxPhotoBoothVIP;I" +
            "ntegrated Security=True;TrustServerCertificate=True")]
        public string QuanLyMusicBoxPhotoBoothVIPConnectionString {
            get {
                return ((string)(this["QuanLyMusicBoxPhotoBoothVIPConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=Immagorst\\MSSQLSERVER01;Initial Catalog=QuanLyMSBPTBVIP;Integrated Se" +
            "curity=True;TrustServerCertificate=True")]
        public string QuanLyMSBPTBVIPConnectionString {
            get {
                return ((string)(this["QuanLyMSBPTBVIPConnectionString"]));
            }
        }
    }
}
