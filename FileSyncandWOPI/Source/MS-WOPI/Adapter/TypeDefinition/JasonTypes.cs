//-----------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------

namespace Microsoft.Protocols.TestSuites.MS_WOPI
{         
    using System.Xml.Serialization;
    using System.Runtime.Serialization;

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sharepoint/soap/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/sharepoint/soap/", IsNullable = false)]
    [DataContract]
    public partial class CheckFileInfo
    {

        /// <remarks/>
        [DataMember(Order = 1)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool AllowAdditionalMicrosoftServices { get; set; }

        /// <remarks/>
        [DataMember(Order = 2)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool AllowExternalMarketplace { get; set; }

        /// <remarks/>
        [DataMember(Order = 3)]
        public string BaseFileName { get; set; }

        /// <remarks/>
        [DataMember(Order = 4)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string BreadcrumbBrandName { get; set; }

        /// <remarks/>
        [DataMember(Order = 5)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string BreadcrumbBrandUrl { get; set; }

        /// <remarks/>
        [DataMember(Order = 6)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string BreadcrumbDocName { get; set; }

        /// <remarks/>
        [DataMember(Order = 7)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string BreadcrumbDocUrl { get; set; }

        /// <remarks/>
        [DataMember(Order = 8)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string BreadcrumbFolderUrl { get; set; }

        /// <remarks/>
        [DataMember(Order = 9)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string ClientUrl { get; set; }

        /// <remarks/>
        [DataMember(Order = 10)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool CloseButtonClosesWindow { get; set; }

        /// <remarks/>
        [DataMember(Order = 11)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ClosePostMessage { get; set; }
        
        /// <remarks/>
        [DataMember(Order = 12)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string CloseUrl { get; set; }

        /// <remarks/>
        [DataMember(Order = 13)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool DisableBrowserCachingOfUserContent { get; set; }

        /// <remarks/>
        [DataMember(Order = 14)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool DisablePrint { get; set; }

        /// <remarks/>
        [DataMember(Order = 15)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool DisableTranslation { get; set; }

        /// <remarks/>
        [DataMember(Order = 16)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string DownloadUrl { get; set; }

        /// <remarks/>
        [DataMember(Order = 17)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string EditAndReplyUrl { get; set; }

        /// <remarks/>
        [DataMember(Order = 18)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool EditModePostMessage { get; set; }

        /// <remarks/>
        [DataMember(Order = 19)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool EditNotificationPostMessage { get; set; }

        /// <remarks/>
        [DataMember(Order = 20)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string FileExtension { get; set; }

        /// <remarks/>
        [DataMember(Order = 21)]
        [System.ComponentModel.DefaultValueAttribute(250)]
        public int FileNameMaxLength { get; set; }

        /// <remarks/>
        [DataMember(Order = 22)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool FileSharingPostMessage { get; set; }

        /// <remarks/>
        [DataMember(Order = 23)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string FileSharingUrl { get; set; }

        /// <remarks/>
        [DataMember(Order = 24)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string FileUrl { get; set; }

        /// <remarks/>
        [DataMember(Order = 25)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string HostAuthenticationId { get; set; }

        /// <remarks/>
        [DataMember(Order = 26)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string HostEditUrl { get; set; }

        /// <remarks/>
        [DataMember(Order = 27)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string HostEmbeddedEditUrl { get; set; }

        /// <remarks/>
        [DataMember(Order = 28)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string HostEmbeddedViewUrl { get; set; }

        /// <remarks/>
        [DataMember(Order = 29)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string HostName { get; set; }

        /// <remarks/>
        [DataMember(Order = 30)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string HostNotes { get; set; }

        /// <remarks/>
        [DataMember(Order = 31)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string HostRestUrl { get; set; }

        /// <remarks/>
        [DataMember(Order = 32)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string HostViewUrl { get; set; }

        /// <remarks/>
        [DataMember(Order = 33)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string IrmPolicyDescription { get; set; }

        /// <remarks/>
        [DataMember(Order = 34)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string IrmPolicyTitle { get; set; }

        /// <remarks/>
        [DataMember(Order = 35)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool LicenseCheckForEditIsEnabled { get; set; }

        /// <remarks/>
        [DataMember(Order = 36)]
        public string OwnerId { get; set; }

        /// <remarks/>
        [DataMember(Order = 37)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string PostMessageOrigin { get; set; }

        /// <remarks/>
        [DataMember(Order = 38)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string PresenceProvider { get; set; }

        /// <remarks/>
        [DataMember(Order = 39)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string PresenceUserId { get; set; }

        /// <remarks/>
        [DataMember(Order = 40)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string PrivacyUrl { get; set; }

        /// <remarks/>
        [DataMember(Order = 41)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string ProtectInClient { get; set; }

        /// <remarks/>
        [DataMember(Order = 42)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public bool ReadOnly { get; set; }

        /// <remarks/>
        [DataMember(Order = 43)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool RestrictedWebViewOnly { get; set; }

        /// <remarks/>
        [DataMember(Order = 44)]
        public string SHA256 { get; set; }

        /// <remarks/>
        [DataMember(Order = 45)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string SignInUrl { get; set; }
 
        /// <remarks/>
        [DataMember(Order = 46)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string SignoutUrl { get; set; }

        /// <remarks/>
        [DataMember(Order = 47)]
        public int Size { get; set; }

        /// <remarks/>
        [DataMember(Order = 48)]
        [System.ComponentModel.DefaultValueAttribute(new string[] { })]
        public string[] SupportedShareUrlTypes { get; set; }

        /// <remarks/>
        [DataMember(Order = 49)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool SupportsCoauth { get; set; }

        /// <remarks/>
        [DataMember(Order = 50)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool SupportsCobalt { get; set; }

        /// <remarks/>
        [DataMember(Order = 51)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool SupportsExtendedLockLength { get; set; }

        /// <remarks/>
        [DataMember(Order = 52)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool SupportsFileCreation { get; set; }

        /// <remarks/>
        [DataMember(Order = 53)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool SupportsFolders { get; set; }

        /// <remarks/>
        [DataMember(Order = 54)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool SupportsGetLock { get; set; }

        /// <remarks/>
        [DataMember(Order = 55)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool SupportsLocks { get; set; }

        /// <remarks/>
        [DataMember(Order = 56)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool SupportsRename { get; set; }
     
        /// <remarks/>
        [DataMember(Order = 57)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool SupportsScenarioLinks { get; set; }

        /// <remarks/>
        [DataMember(Order = 58)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool SupportsSecureStore { get; set; }

        /// <remarks/>
        [DataMember(Order = 59)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool SupportsUpdate { get; set; }

        /// <remarks/>
        [DataMember(Order = 60)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool SupportsUserInfo { get; set; }
      
        /// <remarks/>
        [DataMember(Order = 61)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string TenantId { get; set; }

        /// <remarks/>
        [DataMember(Order = 62)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string TermsOfUseUrl { get; set; }

        /// <remarks/>
        [DataMember(Order = 63)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string TimeZone { get; set; }

        /// <remarks/>
        [DataMember(Order = 64)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string UniqueContentId { get; set; }
     
        /// <remarks/>
        [DataMember(Order = 65)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool UserCanAttend { get; set; }

        /// <remarks/>
        [DataMember(Order = 66)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool UserCanNotWriteRelative { get; set; }

        /// <remarks/>
        [DataMember(Order = 67)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool UserCanPresent { get; set; }

        /// <remarks/>
        [DataMember(Order = 68)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool UserCanRename { get; set; }

        /// <remarks/>
        [DataMember(Order = 69)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool UserCanWrite { get; set; }

        /// <remarks/>
        [DataMember(Order = 70)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string UserFriendlyName { get; set; }

        /// <remarks/>
        [DataMember(Order = 71)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string UserId { get; set; }

        /// <remarks/>
        [DataMember(Order = 72)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string UserInfo { get; set; }

        /// <remarks/>
        [DataMember(Order = 73)]
        public string Version { get; set; }

        /// <remarks/>
        [DataMember(Order = 74)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool WebEditingDisabled { get; set; }

        /// <remarks/>
        [DataMember(Order = 75)]
        [System.ComponentModel.DefaultValueAttribute(new string[] { })]
        public string[] WorkflowType { get; set; }

        /// <remarks/>
        [DataMember(Order = 76)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string WorkflowUrl { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/sharepoint/soap/")]
    [DataContract]
    public partial class ChildrenItem
    {

        /// <remarks/>
        [DataMember(Order = 1)]
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name { get; set; }

        /// <remarks/>
        [DataMember(Order = 2)]
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Url { get; set; }

        /// <remarks/>
        [DataMember(Order = 3)]
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Version { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sharepoint/soap/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/sharepoint/soap/", IsNullable = false)]
    [DataContract]
    public partial class PutRelativeFile
    {

        /// <remarks/>
        [DataMember(Order = 1)]
        public string Name { get; set; }

        /// <remarks/>
        [DataMember(Order = 2)]
        public string Url { get; set; }

        /// <remarks/>
        [DataMember(Order = 3)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string HostViewUrl { get; set; }

        /// <remarks/>
        [DataMember(Order = 4)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string HostEditUrl { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sharepoint/soap/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/sharepoint/soap/", IsNullable = false)]
    [DataContract]
    public partial class ReadSecureStore
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReadSecureStore")]
        [DataMember(Order = 1)]
        public string UserName { get; set; }

        /// <remarks/>
        [DataMember(Order = 2)]
        public string Password { get; set; }

        /// <remarks/>
        [DataMember(Order = 3)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool IsWindowsCredentials { get; set; }

        /// <remarks/>
        [DataMember(Order = 4)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool IsGroup { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sharepoint/soap/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/sharepoint/soap/", IsNullable = false)]
    [DataContract]
    public partial class CheckFolderInfo
    {

        /// <remarks/>
        [DataMember(Order = 1)]
        public string FolderName { get; set; }

        /// <remarks/>
        [DataMember(Order = 2)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string BreadcrumbBrandIconUrl { get; set; }

        /// <remarks/>
        [DataMember(Order = 3)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string BreadcrumbBrandName { get; set; }

        /// <remarks/>
        [DataMember(Order = 4)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string BreadcrumbBrandUrl { get; set; }

        /// <remarks/>
        [DataMember(Order = 5)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string BreadcrumbDocName { get; set; }

        /// <remarks/>
        [DataMember(Order = 6)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string BreadcrumbDocUrl { get; set; }

        /// <remarks/>
        [DataMember(Order = 7)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string BreadcrumbFolderName { get; set; }

        /// <remarks/>
        [DataMember(Order = 8)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string BreadcrumbFolderUrl { get; set; }

        /// <remarks/>
        [DataMember(Order = 9)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string ClientUrl { get; set; }

        /// <remarks/>
        [DataMember(Order = 10)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool CloseButtonClosesWindow { get; set; }

        /// <remarks/>
        [DataMember(Order = 11)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string CloseUrl { get; set; }

        /// <remarks/>
        [DataMember(Order = 12)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string FileSharingUrl { get; set; }

        /// <remarks/>
        [DataMember(Order = 13)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string HostAuthenticationId { get; set; }

        /// <remarks/>
        [DataMember(Order = 14)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string HostEditUrl { get; set; }

        /// <remarks/>
        [DataMember(Order = 15)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string HostEmbeddedEditUrl { get; set; }

        /// <remarks/>
        [DataMember(Order = 16)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string HostEmbeddedViewUrl { get; set; }

        /// <remarks/>
        [DataMember(Order = 17)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string HostName { get; set; }

        /// <remarks/>
        [DataMember(Order = 18)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string HostViewUrl { get; set; }

        /// <remarks/>
        [DataMember(Order = 19)]
        public string OwnerId { get; set; }

        /// <remarks/>
        [DataMember(Order = 20)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string PresenceProvider { get; set; }

        /// <remarks/>
        [DataMember(Order = 21)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string PresenceUserId { get; set; }

        /// <remarks/>
        [DataMember(Order = 22)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string PrivacyUrl { get; set; }

        /// <remarks/>
        [DataMember(Order = 23)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string SignoutUrl { get; set; }

        /// <remarks/>
        [DataMember(Order = 24)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool SupportsSecureStore { get; set; }

        /// <remarks/>
        [DataMember(Order = 25)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string TenantId { get; set; }

        /// <remarks/>
        [DataMember(Order = 26)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string TermsOfUseUrl { get; set; }

        /// <remarks/>
        [DataMember(Order = 27)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool UserCanWrite { get; set; }

        /// <remarks/>
        [DataMember(Order = 28)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string UserFriendlyName { get; set; }

        /// <remarks/>
        [DataMember(Order = 29)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string UserId { get; set; }

        /// <remarks/>
        [DataMember(Order = 30)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool WebEditingDisabled { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/sharepoint/soap/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/sharepoint/soap/", IsNullable = false)]
    [DataContract]
    public partial class EnumerateChildren
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Children")]
        [DataMember(Order = 1)]
        public ChildrenItem[] Children { get; set; }
    }

}