﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using VSShellInterop = global::Microsoft.VisualStudio.Shell.Interop;
using VSShell = global::Microsoft.VisualStudio.Shell;
using DslShell = global::Microsoft.VisualStudio.Modeling.Shell;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
using DslModeling = global::Microsoft.VisualStudio.Modeling;
using System;
using System.Diagnostics;
using System.Drawing.Design;
using System.Linq;
using System.Windows.Forms;
	
namespace nHydrate.DslPackage
{
	/// <summary>
	/// This class implements the VS package that integrates this DSL into Visual Studio.
	/// </summary>
	[VSShell::DefaultRegistryRoot("Software\\Microsoft\\VisualStudio\\11.0")]
	[VSShell::PackageRegistration(RegisterUsing = VSShell::RegistrationMethod.Assembly, UseManagedResourcesOnly = true)]
	[VSShell::ProvideToolWindow(typeof(nHydrateExplorerToolWindow), MultiInstances = false, Style = VSShell::VsDockStyle.Tabbed, Orientation = VSShell::ToolWindowOrientation.Right, Window = "{3AE79031-E1BC-11D0-8F78-00A0C9110057}")]
	[VSShell::ProvideToolWindowVisibility(typeof(nHydrateExplorerToolWindow), Constants.nHydrateEditorFactoryId)]
	[VSShell::ProvideStaticToolboxGroup("@nHydrateToolboxTab;nHydrate.Dsl.dll", "nHydrate.DslPackage.nHydrateToolboxTab")]
	[VSShell::ProvideStaticToolboxItem("nHydrate.DslPackage.nHydrateToolboxTab",
					"@EntityToolboxItem;nHydrate.Dsl.dll", 
					"nHydrate.DslPackage.EntityToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"Entity", 
					"@EntityToolboxBitmap;nHydrate.Dsl.dll", 
					0xff00ff)]
	[VSShell::ProvideStaticToolboxItem("nHydrate.DslPackage.nHydrateToolboxTab",
					"@AssociationToolboxItem;nHydrate.Dsl.dll", 
					"nHydrate.DslPackage.AssociationToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"", 
					"@AssociationToolboxBitmap;nHydrate.Dsl.dll", 
					0xff00ff)]
	[VSShell::ProvideStaticToolboxItem("nHydrate.DslPackage.nHydrateToolboxTab",
					"@InheritanceToolboxItem;nHydrate.Dsl.dll", 
					"nHydrate.DslPackage.InheritanceToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"", 
					"@InheritanceToolboxBitmap;nHydrate.Dsl.dll", 
					0xff00ff)]
	[VSShell::ProvideStaticToolboxItem("nHydrate.DslPackage.nHydrateToolboxTab",
					"@ViewToolboxItem;nHydrate.Dsl.dll", 
					"nHydrate.DslPackage.ViewToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"View", 
					"@ViewToolboxBitmap;nHydrate.Dsl.dll", 
					0xff00ff)]
	[VSShell::ProvideStaticToolboxItem("nHydrate.DslPackage.nHydrateToolboxTab",
					"@FunctionToolboxItem;nHydrate.Dsl.dll", 
					"nHydrate.DslPackage.FunctionToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"Function", 
					"@FunctionToolboxBitmap;nHydrate.Dsl.dll", 
					0xff00ff)]
	[VSShell::ProvideStaticToolboxItem("nHydrate.DslPackage.nHydrateToolboxTab",
					"@StoredProcedureToolboxItem;nHydrate.Dsl.dll", 
					"nHydrate.DslPackage.StoredProcedureToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"StoredProcedure", 
					"@StoredProcedureToolboxBitmap;nHydrate.Dsl.dll", 
					0xff00ff)]
	[VSShell::ProvideStaticToolboxItem("nHydrate.DslPackage.nHydrateToolboxTab",
					"@ViewLinkToolboxItem;nHydrate.Dsl.dll", 
					"nHydrate.DslPackage.ViewLinkToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"", 
					"@ViewLinkToolboxBitmap;nHydrate.Dsl.dll", 
					0xff00ff)]
	[VSShell::ProvideEditorFactory(typeof(nHydrateEditorFactory), 103, TrustLevel = VSShellInterop::__VSEDITORTRUSTLEVEL.ETL_AlwaysTrusted)]
	[VSShell::ProvideEditorExtension(typeof(nHydrateEditorFactory), "." + Constants.DesignerFileExtension, 50)]
	[VSShell::ProvideEditorLogicalView(typeof(nHydrateEditorFactory), "{7651A702-06E5-11D1-8EBD-00A0C90F26EA}")] // Designer logical view GUID i.e. VSConstants.LOGVIEWID_Designer
	[DslShell::ProvideRelatedFile("." + Constants.DesignerFileExtension, Constants.DefaultDiagramExtension,
		ProjectSystem = DslShell::ProvideRelatedFileAttribute.CSharpProjectGuid,
		FileOptions = DslShell::RelatedFileType.FileName)]
	[DslShell::ProvideRelatedFile("." + Constants.DesignerFileExtension, Constants.DefaultDiagramExtension,
		ProjectSystem = DslShell::ProvideRelatedFileAttribute.VisualBasicProjectGuid,
		FileOptions = DslShell::RelatedFileType.FileName)]
	[DslShell::RegisterAsDslToolsEditor]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[DslShell::ProvideBindingPath]
	[DslShell::ProvideXmlEditorChooserBlockSxSWithXmlEditor(@"nHydrate", typeof(nHydrateEditorFactory))]

	internal abstract partial class nHydratePackageBase : DslShell::ModelingPackage
	{
		protected global::nHydrate.Dsl.nHydrateToolboxHelper toolboxHelper;	
		
		/// <summary>
		/// Initialization method called by the package base class when this package is loaded.
		/// </summary>
		protected override void Initialize()
		{
			base.Initialize();

			// Register the editor factory used to create the DSL editor.
			this.RegisterEditorFactory(new nHydrateEditorFactory(this));
			
			// Initialize the toolbox helper
			toolboxHelper = new global::nHydrate.Dsl.nHydrateToolboxHelper(this);

			// Create the command set that handles menu commands provided by this package.
			nHydrateCommandSet commandSet = new nHydrateCommandSet(this);
			commandSet.Initialize();
			
			// Create the command set that handles cut/copy/paste commands provided by this package.
			nHydrateClipboardCommandSet clipboardCommandSet = new nHydrateClipboardCommandSet(this);
			clipboardCommandSet.Initialize();
			
			// Register the model explorer tool window for this DSL.
			this.AddToolWindow(typeof(nHydrateExplorerToolWindow));

			// Initialize Extension Registars
			// this is a partial method call
			this.InitializeExtensions();

			// Add dynamic toolbox items
			this.SetupDynamicToolbox();
		}

		/// <summary>
		/// Partial method to initialize ExtensionRegistrars (if any) in the DslPackage
		/// </summary>
		partial void InitializeExtensions();
		
		/// <summary>
		/// Returns any dynamic tool items for the designer
		/// </summary>
		/// <remarks>The default implementation is to return the list of items from the generated toolbox helper.</remarks>
		protected override global::System.Collections.Generic.IList<DslDesign::ModelingToolboxItem> CreateToolboxItems()
		{
			try
			{
				Debug.Assert(toolboxHelper != null, "Toolbox helper is not initialized");
				return toolboxHelper.CreateToolboxItems();
			}
			catch(global::System.Exception e)
			{
				global::System.Diagnostics.Debug.Fail("Exception thrown during toolbox item creation.  This may result in Package Load Failure:\r\n\r\n" + e);
				throw;
			}
		}
		
		
		/// <summary>
		/// Given a toolbox item "unique ID" and a data format identifier, returns the content of
		/// the data format. 
		/// </summary>
		/// <param name="itemId">The unique ToolboxItem to retrieve data for</param>
		/// <param name="format">The desired format of the resulting data</param>
		protected override object GetToolboxItemData(string itemId, DataFormats.Format format)
		{
			Debug.Assert(toolboxHelper != null, "Toolbox helper is not initialized");
		
			// Retrieve the specified ToolboxItem from the DSL
			return toolboxHelper.GetToolboxItemData(itemId, format);
		}
	}

}

//
// Package attributes which may need to change are placed on the partial class below, rather than in the main include file.
//
namespace nHydrate.DslPackage
{
	/// <summary>
	/// Double-derived class to allow easier code customization.
	/// </summary>
	[VSShell::ProvideMenuResource("1000.ctmenu", version: 225)]
	[VSShell::ProvideToolboxItems(1)]
	[global::Microsoft.VisualStudio.TextTemplating.VSHost.ProvideDirectiveProcessor(typeof(global::nHydrate.Dsl.nHydrateDirectiveProcessor), global::nHydrate.Dsl.nHydrateDirectiveProcessor.nHydrateDirectiveProcessorName, "A directive processor that provides access to nHydrate files")]
	[global::System.Runtime.InteropServices.Guid(Constants.nHydratePackageId)]
	internal sealed partial class nHydratePackage : nHydratePackageBase
	{
	}
}