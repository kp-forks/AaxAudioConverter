﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace audiamus.aaxconv.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool NonParallel {
            get {
                return ((bool)(this["NonParallel"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string InputDirectory {
            get {
                return ((string)(this["InputDirectory"]));
            }
            set {
                this["InputDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string OutputDirectory {
            get {
                return ((string)(this["OutputDirectory"]));
            }
            set {
                this["OutputDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string FFMpegDirectory {
            get {
                return ((string)(this["FFMpegDirectory"]));
            }
            set {
                this["FFMpegDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("mp3")]
        public global::audiamus.aaxconv.lib.EConvFormat ConvFormat {
            get {
                return ((global::audiamus.aaxconv.lib.EConvFormat)(this["ConvFormat"]));
            }
            set {
                this["ConvFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("chapters")]
        public global::audiamus.aaxconv.lib.EConvMode ConvMode {
            get {
                return ((global::audiamus.aaxconv.lib.EConvMode)(this["ConvMode"]));
            }
            set {
                this["ConvMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public byte TrkDurMins {
            get {
                return ((byte)(this["TrkDurMins"]));
            }
            set {
                this["TrkDurMins"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("track_book_author")]
        public global::audiamus.aaxconv.lib.EFileNaming FileNaming {
            get {
                return ((global::audiamus.aaxconv.lib.EFileNaming)(this["FileNaming"]));
            }
            set {
                this["FileNaming"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("track_book")]
        public global::audiamus.aaxconv.lib.ETitleNaming TitleNaming {
            get {
                return ((global::audiamus.aaxconv.lib.ETitleNaming)(this["TitleNaming"]));
            }
            set {
                this["TitleNaming"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("track")]
        public global::audiamus.aaxconv.lib.ETrackNumbering TrackNumbering {
            get {
                return ((global::audiamus.aaxconv.lib.ETrackNumbering)(this["TrackNumbering"]));
            }
            set {
                this["TrackNumbering"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Narrator {
            get {
                return ((bool)(this["Narrator"]));
            }
            set {
                this["Narrator"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("standard")]
        public global::audiamus.aaxconv.lib.EGeneralNaming GenreNaming {
            get {
                return ((global::audiamus.aaxconv.lib.EGeneralNaming)(this["GenreNaming"]));
            }
            set {
                this["GenreNaming"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string GenreName {
            get {
                return ((string)(this["GenreName"]));
            }
            set {
                this["GenreName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("standard")]
        public global::audiamus.aaxconv.lib.EGeneralNamingEx ChapterNaming {
            get {
                return ((global::audiamus.aaxconv.lib.EGeneralNamingEx)(this["ChapterNaming"]));
            }
            set {
                this["ChapterNaming"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ChapterName {
            get {
                return ((string)(this["ChapterName"]));
            }
            set {
                this["ChapterName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SeriesTitleLeft {
            get {
                return ((bool)(this["SeriesTitleLeft"]));
            }
            set {
                this["SeriesTitleLeft"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("no")]
        public global::audiamus.aaxconv.lib.ELongTitle LongBookTitle {
            get {
                return ((global::audiamus.aaxconv.lib.ELongTitle)(this["LongBookTitle"]));
            }
            set {
                this["LongBookTitle"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("standard")]
        public global::audiamus.aaxconv.lib.EGeneralNaming PartNaming {
            get {
                return ((global::audiamus.aaxconv.lib.EGeneralNaming)(this["PartNaming"]));
            }
            set {
                this["PartNaming"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string PartName {
            get {
                return ((string)(this["PartName"]));
            }
            set {
                this["PartName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Nullable<System.Boolean> FileAssoc {
            get {
                return ((global::System.Nullable<System.Boolean>)(this["FileAssoc"]));
            }
            set {
                this["FileAssoc"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Nullable<System.UInt32> ActivationCode {
            get {
                return ((global::System.Nullable<System.UInt32>)(this["ActivationCode"]));
            }
            set {
                this["ActivationCode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Language {
            get {
                return ((string)(this["Language"]));
            }
            set {
                this["Language"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string PartNames {
            get {
                return ((string)(this["PartNames"]));
            }
            set {
                this["PartNames"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string AddnlValTitlePunct {
            get {
                return ((string)(this["AddnlValTitlePunct"]));
            }
            set {
                this["AddnlValTitlePunct"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Genres {
            get {
                return ((string)(this["Genres"]));
            }
            set {
                this["Genres"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool FlatFolders {
            get {
                return ((bool)(this["FlatFolders"]));
            }
            set {
                this["FlatFolders"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("author_book")]
        public global::audiamus.aaxconv.lib.EFlatFolderNaming FlatFolderNaming {
            get {
                return ((global::audiamus.aaxconv.lib.EFlatFolderNaming)(this["FlatFolderNaming"]));
            }
            set {
                this["FlatFolderNaming"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ExtraMetaFiles {
            get {
                return ((bool)(this["ExtraMetaFiles"]));
            }
            set {
                this["ExtraMetaFiles"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("promptForInstall")]
        public global::audiamus.aaxconv.lib.EOnlineUpdate OnlineUpdate {
            get {
                return ((global::audiamus.aaxconv.lib.EOnlineUpdate)(this["OnlineUpdate"]));
            }
            set {
                this["OnlineUpdate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("25")]
        public uint ShortChapterSec {
            get {
                return ((uint)(this["ShortChapterSec"]));
            }
            set {
                this["ShortChapterSec"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public uint VeryShortChapterSec {
            get {
                return ((uint)(this["VeryShortChapterSec"]));
            }
            set {
                this["VeryShortChapterSec"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("splitChapterMode")]
        public global::audiamus.aaxconv.lib.EVerifyAdjustChapters VerifyAdjustChapters {
            get {
                return ((global::audiamus.aaxconv.lib.EVerifyAdjustChapters)(this["VerifyAdjustChapters"]));
            }
            set {
                this["VerifyAdjustChapters"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Latin1EncodingForPlaylist {
            get {
                return ((bool)(this["Latin1EncodingForPlaylist"]));
            }
            set {
                this["Latin1EncodingForPlaylist"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("yes")]
        public global::audiamus.aaxconv.lib.ENamedChapters NamedChapters {
            get {
                return ((global::audiamus.aaxconv.lib.ENamedChapters)(this["NamedChapters"]));
            }
            set {
                this["NamedChapters"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AutoLaunchPlayer {
            get {
                return ((bool)(this["AutoLaunchPlayer"]));
            }
            set {
                this["AutoLaunchPlayer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool M4B {
            get {
                return ((bool)(this["M4B"]));
            }
            set {
                this["M4B"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("no")]
        public global::audiamus.aaxconv.lib.EAaxCopyMode AaxCopyMode {
            get {
                return ((global::audiamus.aaxconv.lib.EAaxCopyMode)(this["AaxCopyMode"]));
            }
            set {
                this["AaxCopyMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string AaxCopyDirectory {
            get {
                return ((string)(this["AaxCopyDirectory"]));
            }
            set {
                this["AaxCopyDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Version {
            get {
                return ((string)(this["Version"]));
            }
            set {
                this["Version"] = value;
            }
        }
    }
}
