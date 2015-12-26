//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// Created via this command line: "C:\CRM Tools\XrmToolBox\Plugins\CrmSvcUtil Ref\crmsvcutil.exe" /url:"https://idgenerator.api.crm.dynamics.com/XRMServices/2011/Organization.svc" /namespace:"Xrm.Entities" /out:"C:\Temp\CrmContext.cs" /servicecontextname:"CrmContext" /codecustomization:"DLaB.CrmSvcUtilExtensions.Entity.CustomizeCodeDomService,DLaB.CrmSvcUtilExtensions" /codegenerationservice:"DLaB.CrmSvcUtilExtensions.Entity.CustomCodeGenerationService,DLaB.CrmSvcUtilExtensions" /codewriterfilter:"DLaB.CrmSvcUtilExtensions.Entity.CodeWriterFilterService,DLaB.CrmSvcUtilExtensions" /namingservice:"DLaB.CrmSvcUtilExtensions.Entity.OverridePropertyNames,DLaB.CrmSvcUtilExtensions" /username:"dlabar@idgenerator.onmicrosoft.com" /password:"********" 
//------------------------------------------------------------------------------

[assembly: Microsoft.Xrm.Sdk.Client.ProxyTypesAssemblyAttribute()]

namespace DLaB.XrmAutoNumberGenerator.Entities
{
	
	/// <summary>
	/// Represents a source of entities bound to a CRM service. It tracks and manages changes made to the retrieved entities.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.1.0001.3108")]
	public partial class CrmContext : Microsoft.Xrm.Sdk.Client.OrganizationServiceContext
	{
		
		/// <summary>
		/// Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public CrmContext(Microsoft.Xrm.Sdk.IOrganizationService service) : 
				base(service)
		{
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Xrm.Entities.dlab_AutoNumbering"/> entities.
		/// </summary>
		public System.Linq.IQueryable<DLaB.XrmAutoNumberGenerator.Entities.dlab_AutoNumbering> dlab_AutoNumberingSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<DLaB.XrmAutoNumberGenerator.Entities.dlab_AutoNumbering>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Xrm.Entities.PluginType"/> entities.
		/// </summary>
		public System.Linq.IQueryable<DLaB.XrmAutoNumberGenerator.Entities.PluginType> PluginTypeSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<DLaB.XrmAutoNumberGenerator.Entities.PluginType>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Xrm.Entities.SdkMessage"/> entities.
		/// </summary>
		public System.Linq.IQueryable<DLaB.XrmAutoNumberGenerator.Entities.SdkMessage> SdkMessageSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<DLaB.XrmAutoNumberGenerator.Entities.SdkMessage>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Xrm.Entities.SdkMessageFilter"/> entities.
		/// </summary>
		public System.Linq.IQueryable<DLaB.XrmAutoNumberGenerator.Entities.SdkMessageFilter> SdkMessageFilterSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<DLaB.XrmAutoNumberGenerator.Entities.SdkMessageFilter>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="Xrm.Entities.SdkMessageProcessingStep"/> entities.
		/// </summary>
		public System.Linq.IQueryable<DLaB.XrmAutoNumberGenerator.Entities.SdkMessageProcessingStep> SdkMessageProcessingStepSet
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.CreateQuery<DLaB.XrmAutoNumberGenerator.Entities.SdkMessageProcessingStep>();
			}
		}
	}
	
	internal sealed class EntityOptionSetEnum
	{
		
		[System.Diagnostics.DebuggerNonUserCode()]
		public static System.Nullable<int> GetEnum(Microsoft.Xrm.Sdk.Entity entity, string attributeLogicalName)
		{
			if (entity.Attributes.ContainsKey(attributeLogicalName))
			{
				Microsoft.Xrm.Sdk.OptionSetValue value = entity.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>(attributeLogicalName);
				if (value != null)
				{
					return value.Value;
				}
			}
			return null;
		}
	}
}