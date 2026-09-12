using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2Cpp;
using Il2CppCore.Configuration;
using Il2CppCore.UILogic.Admin.Items;
using Il2CppCore.UILogic.Components.ContextMenu;
using Il2CppCysharp.Threading.Tasks;
using Il2CppCysharp.Threading.Tasks.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Text.RegularExpressions;
using Il2CppSystem.Xml;

namespace Il2CppCore.UILogic.Admin;

public class AdminMenu : Il2CppSystem.Object
{
	public sealed class MenuItemLocationData : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_container;

		private static readonly System.IntPtr NativeFieldInfoPtr_position;

		public unsafe List<BasicItem> container
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_container);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BasicItem>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_container)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe int position
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_position);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_position)) = num;
			}
		}

		static MenuItemLocationData()
		{
			Il2CppClassPointerStore<MenuItemLocationData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "MenuItemLocationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MenuItemLocationData>.NativeClassPtr);
			NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuItemLocationData>.NativeClassPtr, "container");
			NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuItemLocationData>.NativeClassPtr, "position");
		}

		public MenuItemLocationData(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public MenuItemLocationData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MenuItemLocationData>.NativeClassPtr))
		{
		}
	}

	[ObfuscatedName("Core.UILogic.Admin.AdminMenu+<LoadXmlFile>d__55")]
	public sealed class _LoadXmlFile_d__55 : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;

		private static readonly System.IntPtr NativeFieldInfoPtr_filePath;

		private static readonly System.IntPtr NativeFieldInfoPtr_fileLoadingErrorCallback;

		private static readonly System.IntPtr NativeFieldInfoPtr_fileLoadedCallback;

		private static readonly System.IntPtr NativeFieldInfoPtr__xmlDocument_5__2;

		private static readonly System.IntPtr NativeFieldInfoPtr__reader_5__3;

		private static readonly System.IntPtr NativeFieldInfoPtr___u__1;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

		public unsafe int __1__state
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = num;
			}
		}

		public unsafe AsyncUniTaskMethodBuilder<bool> __t__builder
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___t__builder);
				return new AsyncUniTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder<bool>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asyncUniTaskMethodBuilder)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder<bool>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe string filePath
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filePath);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filePath)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe Il2CppSystem.Action<string> fileLoadingErrorCallback
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fileLoadingErrorCallback);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<string>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fileLoadingErrorCallback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
			}
		}

		public unsafe Il2CppSystem.Action<XmlDocument> fileLoadedCallback
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fileLoadedCallback);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<XmlDocument>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fileLoadedCallback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
			}
		}

		public unsafe XmlDocument _xmlDocument_5__2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__xmlDocument_5__2);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlDocument>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__xmlDocument_5__2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)xmlDocument));
			}
		}

		public unsafe XmlReader _reader_5__3
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__reader_5__3);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlReader>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__reader_5__3)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)xmlReader));
			}
		}

		public unsafe Il2CppSystem.Runtime.CompilerServices.TaskAwaiter<XmlNodeType> __u__1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__1);
				return new Il2CppSystem.Runtime.CompilerServices.TaskAwaiter<XmlNodeType>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.TaskAwaiter<XmlNodeType>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)taskAwaiter)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.TaskAwaiter<XmlNodeType>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static _LoadXmlFile_d__55()
		{
			Il2CppClassPointerStore<_LoadXmlFile_d__55>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "<LoadXmlFile>d__55");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_LoadXmlFile_d__55>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadXmlFile_d__55>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadXmlFile_d__55>.NativeClassPtr, "<>t__builder");
			NativeFieldInfoPtr_filePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadXmlFile_d__55>.NativeClassPtr, "filePath");
			NativeFieldInfoPtr_fileLoadingErrorCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadXmlFile_d__55>.NativeClassPtr, "fileLoadingErrorCallback");
			NativeFieldInfoPtr_fileLoadedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadXmlFile_d__55>.NativeClassPtr, "fileLoadedCallback");
			NativeFieldInfoPtr__xmlDocument_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadXmlFile_d__55>.NativeClassPtr, "<xmlDocument>5__2");
			NativeFieldInfoPtr__reader_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadXmlFile_d__55>.NativeClassPtr, "<reader>5__3");
			NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_LoadXmlFile_d__55>.NativeClassPtr, "<>u__1");
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_LoadXmlFile_d__55>.NativeClassPtr, 100710916);
			NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_LoadXmlFile_d__55>.NativeClassPtr, 100710917);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1397853, XrefRangeEnd = 1397893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1397893, XrefRangeEnd = 1397896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetStateMachine(Il2CppSystem.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stateMachine);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public _LoadXmlFile_d__55(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public _LoadXmlFile_d__55()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_LoadXmlFile_d__55>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_messageBus;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_playerService;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_commandService;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_dofusConfig;

	private static readonly System.IntPtr NativeFieldInfoPtr_LocalConfigPath;

	private static readonly System.IntPtr NativeFieldInfoPtr_RanksFileName;

	private static readonly System.IntPtr NativeFieldInfoPtr_MenuAdminFileName;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdminNodeOperationItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdminNodeOperationAdd;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdminNodeOperationMove;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdminNodeOperationDelete;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdminNodeTypeBatch;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdminNodeTypeLoadXml;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdminNodeTypeMenu;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdminNodeTypePrepareCommand;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdminNodeTypeSendChat;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdminNodeTypeSendCommand;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdminNodeTypeSeparator;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdminNodeTypeStartup;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdminNodeTypeStatic;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdminAddOperationFirst;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdminAddOperationLast;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdminAddOperationBefore;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdminAddOperationAfter;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdminXmlAttributeCommand;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdminXmlAttributeDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdminXmlAttributeHelp;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdminXmlAttributeLabel;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdminXmlAttributeLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdminXmlAttributePosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdminXmlAttributeRank;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdminXmlAttributeRepeat;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdminXmlAttributeRights;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdminXmlAttributeTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdminXmlAttributeType;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_menu;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_startCommands;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_rank;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_hierarchyString;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_rights;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_menuAdminUrls;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_parameterRegex;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ezp_faa_eww_ewy_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildContextMenu_Public_Void_DofusContextualMenu_Dictionary_2_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnStart_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseNode_Private_Void_XmlNode_List_1_BasicItem_List_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNodeLocalizationParameters_Private_Dictionary_2_String_String_XmlNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseItemOperation_Private_BasicItem_XmlNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseMoveOperation_Private_Void_XmlNode_List_1_BasicItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseDeleteOperation_Private_Void_XmlNode_List_1_BasicItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseAddOperation_Private_Void_XmlNode_List_1_BasicItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveMenuItem_Private_Void_List_1_BasicItem_byref_MenuItemLocationData_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddMenuItem_Private_Void_List_1_BasicItem_BasicItem_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LocateMenuItem_Private_Static_Boolean_String_List_1_BasicItem_byref_MenuItemLocationData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadXmlFile_Private_Static_UniTask_1_Boolean_String_Action_1_XmlDocument_Action_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadXmlAttributeString_Private_Static_String_XmlNode_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadXmlAttributeValue_Private_Static_Int32_XmlNode_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnRanksFileLoaded_Private_Void_XmlDocument_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddAdminFileIfAvailable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnFileLoaded_Private_Void_XmlDocument_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnOverwriteFileLoaded_Private_Void_XmlDocument_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnLoadError_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnRanksLoadError_Private_Void_String_0;

	public unsafe ezp m_messageBus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_messageBus);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ezp>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_messageBus)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ezp2));
		}
	}

	public unsafe faa m_playerService
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_playerService);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<faa>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_playerService)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)faa2));
		}
	}

	public unsafe eww m_commandService
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_commandService);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<eww>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_commandService)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eww2));
		}
	}

	public unsafe ApplicationConfig m_dofusConfig
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_dofusConfig);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ApplicationConfig>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_dofusConfig)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)applicationConfig));
		}
	}

	public unsafe static string LocalConfigPath
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LocalConfigPath, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LocalConfigPath, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string RanksFileName
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RanksFileName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RanksFileName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string MenuAdminFileName
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MenuAdminFileName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MenuAdminFileName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string AdminNodeOperationItem
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdminNodeOperationItem, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdminNodeOperationItem, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string AdminNodeOperationAdd
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdminNodeOperationAdd, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdminNodeOperationAdd, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string AdminNodeOperationMove
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdminNodeOperationMove, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdminNodeOperationMove, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string AdminNodeOperationDelete
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdminNodeOperationDelete, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdminNodeOperationDelete, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string AdminNodeTypeBatch
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdminNodeTypeBatch, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdminNodeTypeBatch, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string AdminNodeTypeLoadXml
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdminNodeTypeLoadXml, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdminNodeTypeLoadXml, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string AdminNodeTypeMenu
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdminNodeTypeMenu, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdminNodeTypeMenu, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string AdminNodeTypePrepareCommand
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdminNodeTypePrepareCommand, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdminNodeTypePrepareCommand, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string AdminNodeTypeSendChat
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdminNodeTypeSendChat, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdminNodeTypeSendChat, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string AdminNodeTypeSendCommand
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdminNodeTypeSendCommand, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdminNodeTypeSendCommand, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string AdminNodeTypeSeparator
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdminNodeTypeSeparator, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdminNodeTypeSeparator, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string AdminNodeTypeStartup
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdminNodeTypeStartup, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdminNodeTypeStartup, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string AdminNodeTypeStatic
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdminNodeTypeStatic, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdminNodeTypeStatic, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string AdminAddOperationFirst
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdminAddOperationFirst, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdminAddOperationFirst, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string AdminAddOperationLast
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdminAddOperationLast, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdminAddOperationLast, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string AdminAddOperationBefore
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdminAddOperationBefore, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdminAddOperationBefore, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string AdminAddOperationAfter
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdminAddOperationAfter, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdminAddOperationAfter, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string AdminXmlAttributeCommand
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdminXmlAttributeCommand, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdminXmlAttributeCommand, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string AdminXmlAttributeDelay
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdminXmlAttributeDelay, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdminXmlAttributeDelay, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string AdminXmlAttributeHelp
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdminXmlAttributeHelp, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdminXmlAttributeHelp, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string AdminXmlAttributeLabel
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdminXmlAttributeLabel, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdminXmlAttributeLabel, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string AdminXmlAttributeLevel
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdminXmlAttributeLevel, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdminXmlAttributeLevel, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string AdminXmlAttributePosition
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdminXmlAttributePosition, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdminXmlAttributePosition, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string AdminXmlAttributeRank
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdminXmlAttributeRank, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdminXmlAttributeRank, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string AdminXmlAttributeRepeat
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdminXmlAttributeRepeat, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdminXmlAttributeRepeat, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string AdminXmlAttributeRights
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdminXmlAttributeRights, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdminXmlAttributeRights, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string AdminXmlAttributeTarget
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdminXmlAttributeTarget, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdminXmlAttributeTarget, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string AdminXmlAttributeType
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AdminXmlAttributeType, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AdminXmlAttributeType, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<BasicItem> m_menu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_menu);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BasicItem>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_menu)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<BasicItem> m_startCommands
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_startCommands);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BasicItem>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_startCommands)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe int m_rank
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_rank);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_rank)) = num;
		}
	}

	public unsafe string m_hierarchyString
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_hierarchyString);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_hierarchyString)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe List<string> m_rights
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_rights);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_rights)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Stack<string> m_menuAdminUrls
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_menuAdminUrls);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Stack<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_menuAdminUrls)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stack));
		}
	}

	public unsafe Regex m_parameterRegex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_parameterRegex);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Regex>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_parameterRegex)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)regex));
		}
	}

	static AdminMenu()
	{
		Il2CppClassPointerStore<AdminMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Core.dll", "Core.UILogic.Admin", "AdminMenu");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr);
		NativeFieldInfoPtr_m_messageBus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "m_messageBus");
		NativeFieldInfoPtr_m_playerService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "m_playerService");
		NativeFieldInfoPtr_m_commandService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "m_commandService");
		NativeFieldInfoPtr_m_dofusConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "m_dofusConfig");
		NativeFieldInfoPtr_LocalConfigPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "LocalConfigPath");
		NativeFieldInfoPtr_RanksFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "RanksFileName");
		NativeFieldInfoPtr_MenuAdminFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "MenuAdminFileName");
		NativeFieldInfoPtr_AdminNodeOperationItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "AdminNodeOperationItem");
		NativeFieldInfoPtr_AdminNodeOperationAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "AdminNodeOperationAdd");
		NativeFieldInfoPtr_AdminNodeOperationMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "AdminNodeOperationMove");
		NativeFieldInfoPtr_AdminNodeOperationDelete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "AdminNodeOperationDelete");
		NativeFieldInfoPtr_AdminNodeTypeBatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "AdminNodeTypeBatch");
		NativeFieldInfoPtr_AdminNodeTypeLoadXml = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "AdminNodeTypeLoadXml");
		NativeFieldInfoPtr_AdminNodeTypeMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "AdminNodeTypeMenu");
		NativeFieldInfoPtr_AdminNodeTypePrepareCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "AdminNodeTypePrepareCommand");
		NativeFieldInfoPtr_AdminNodeTypeSendChat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "AdminNodeTypeSendChat");
		NativeFieldInfoPtr_AdminNodeTypeSendCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "AdminNodeTypeSendCommand");
		NativeFieldInfoPtr_AdminNodeTypeSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "AdminNodeTypeSeparator");
		NativeFieldInfoPtr_AdminNodeTypeStartup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "AdminNodeTypeStartup");
		NativeFieldInfoPtr_AdminNodeTypeStatic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "AdminNodeTypeStatic");
		NativeFieldInfoPtr_AdminAddOperationFirst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "AdminAddOperationFirst");
		NativeFieldInfoPtr_AdminAddOperationLast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "AdminAddOperationLast");
		NativeFieldInfoPtr_AdminAddOperationBefore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "AdminAddOperationBefore");
		NativeFieldInfoPtr_AdminAddOperationAfter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "AdminAddOperationAfter");
		NativeFieldInfoPtr_AdminXmlAttributeCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "AdminXmlAttributeCommand");
		NativeFieldInfoPtr_AdminXmlAttributeDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "AdminXmlAttributeDelay");
		NativeFieldInfoPtr_AdminXmlAttributeHelp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "AdminXmlAttributeHelp");
		NativeFieldInfoPtr_AdminXmlAttributeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "AdminXmlAttributeLabel");
		NativeFieldInfoPtr_AdminXmlAttributeLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "AdminXmlAttributeLevel");
		NativeFieldInfoPtr_AdminXmlAttributePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "AdminXmlAttributePosition");
		NativeFieldInfoPtr_AdminXmlAttributeRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "AdminXmlAttributeRank");
		NativeFieldInfoPtr_AdminXmlAttributeRepeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "AdminXmlAttributeRepeat");
		NativeFieldInfoPtr_AdminXmlAttributeRights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "AdminXmlAttributeRights");
		NativeFieldInfoPtr_AdminXmlAttributeTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "AdminXmlAttributeTarget");
		NativeFieldInfoPtr_AdminXmlAttributeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "AdminXmlAttributeType");
		NativeFieldInfoPtr_m_menu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "m_menu");
		NativeFieldInfoPtr_m_startCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "m_startCommands");
		NativeFieldInfoPtr_m_rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "m_rank");
		NativeFieldInfoPtr_m_hierarchyString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "m_hierarchyString");
		NativeFieldInfoPtr_m_rights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "m_rights");
		NativeFieldInfoPtr_m_menuAdminUrls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "m_menuAdminUrls");
		NativeFieldInfoPtr_m_parameterRegex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, "m_parameterRegex");
		NativeMethodInfoPtr__ctor_Public_Void_ezp_faa_eww_ewy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, 100710895);
		NativeMethodInfoPtr_BuildContextMenu_Public_Void_DofusContextualMenu_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, 100710896);
		NativeMethodInfoPtr_OnStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, 100710897);
		NativeMethodInfoPtr_ParseNode_Private_Void_XmlNode_List_1_BasicItem_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, 100710898);
		NativeMethodInfoPtr_GetNodeLocalizationParameters_Private_Dictionary_2_String_String_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, 100710899);
		NativeMethodInfoPtr_ParseItemOperation_Private_BasicItem_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, 100710900);
		NativeMethodInfoPtr_ParseMoveOperation_Private_Void_XmlNode_List_1_BasicItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, 100710901);
		NativeMethodInfoPtr_ParseDeleteOperation_Private_Void_XmlNode_List_1_BasicItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, 100710902);
		NativeMethodInfoPtr_ParseAddOperation_Private_Void_XmlNode_List_1_BasicItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, 100710903);
		NativeMethodInfoPtr_MoveMenuItem_Private_Void_List_1_BasicItem_byref_MenuItemLocationData_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, 100710904);
		NativeMethodInfoPtr_AddMenuItem_Private_Void_List_1_BasicItem_BasicItem_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, 100710905);
		NativeMethodInfoPtr_LocateMenuItem_Private_Static_Boolean_String_List_1_BasicItem_byref_MenuItemLocationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, 100710906);
		NativeMethodInfoPtr_LoadXmlFile_Private_Static_UniTask_1_Boolean_String_Action_1_XmlDocument_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, 100710907);
		NativeMethodInfoPtr_ReadXmlAttributeString_Private_Static_String_XmlNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, 100710908);
		NativeMethodInfoPtr_ReadXmlAttributeValue_Private_Static_Int32_XmlNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, 100710909);
		NativeMethodInfoPtr_OnRanksFileLoaded_Private_Void_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, 100710910);
		NativeMethodInfoPtr_AddAdminFileIfAvailable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, 100710911);
		NativeMethodInfoPtr_OnFileLoaded_Private_Void_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, 100710912);
		NativeMethodInfoPtr_OnOverwriteFileLoaded_Private_Void_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, 100710913);
		NativeMethodInfoPtr_OnLoadError_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, 100710914);
		NativeMethodInfoPtr_OnRanksLoadError_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr, 100710915);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1397941, RefRangeEnd = 1397950, XrefRangeStart = 1397896, XrefRangeEnd = 1397941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AdminMenu(ezp messageBus, faa playerService, eww commandService, ewy configurationService)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdminMenu>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)messageBus);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerService);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)commandService);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)configurationService);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ezp_faa_eww_ewy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1397966, RefRangeEnd = 1397969, XrefRangeStart = 1397950, XrefRangeEnd = 1397966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuildContextMenu(DofusContextualMenu contextualMenu, Dictionary<string, string> replacementParams)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)contextualMenu);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)replacementParams);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildContextMenu_Public_Void_DofusContextualMenu_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1397993, RefRangeEnd = 1397997, XrefRangeStart = 1397969, XrefRangeEnd = 1397993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1398048, RefRangeEnd = 1398053, XrefRangeStart = 1397997, XrefRangeEnd = 1398048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ParseNode(XmlNode node, List<BasicItem> container, List<string> rights = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)container);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rights);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseNode_Private_Void_XmlNode_List_1_BasicItem_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1398083, RefRangeEnd = 1398085, XrefRangeStart = 1398053, XrefRangeEnd = 1398083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dictionary<string, string> GetNodeLocalizationParameters(XmlNode node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNodeLocalizationParameters_Private_Dictionary_2_String_String_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1398233, RefRangeEnd = 1398235, XrefRangeStart = 1398085, XrefRangeEnd = 1398233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BasicItem ParseItemOperation(XmlNode node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseItemOperation_Private_BasicItem_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BasicItem>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1398254, RefRangeEnd = 1398255, XrefRangeStart = 1398235, XrefRangeEnd = 1398254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ParseMoveOperation(XmlNode node, List<BasicItem> container)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)container);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseMoveOperation_Private_Void_XmlNode_List_1_BasicItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1398266, RefRangeEnd = 1398267, XrefRangeStart = 1398255, XrefRangeEnd = 1398266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ParseDeleteOperation(XmlNode node, List<BasicItem> container)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)container);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseDeleteOperation_Private_Void_XmlNode_List_1_BasicItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1398302, RefRangeEnd = 1398303, XrefRangeStart = 1398267, XrefRangeEnd = 1398302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ParseAddOperation(XmlNode node, List<BasicItem> container)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)container);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseAddOperation_Private_Void_XmlNode_List_1_BasicItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1398311, RefRangeEnd = 1398313, XrefRangeStart = 1398303, XrefRangeEnd = 1398311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveMenuItem(List<BasicItem> container, [In] ref MenuItemLocationData locationData, string target = "", string position = "")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)container);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)locationData));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(target);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(position);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveMenuItem_Private_Void_List_1_BasicItem_byref_MenuItemLocationData_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1398348, RefRangeEnd = 1398350, XrefRangeStart = 1398313, XrefRangeEnd = 1398348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddMenuItem(List<BasicItem> container, BasicItem item, string target = "", string position = "")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)container);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(target);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(position);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddMenuItem_Private_Void_List_1_BasicItem_BasicItem_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1398361, RefRangeEnd = 1398365, XrefRangeStart = 1398350, XrefRangeEnd = 1398361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool LocateMenuItem(string target, List<BasicItem> container, out MenuItemLocationData locationData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(target);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)container);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LocateMenuItem_Private_Static_Boolean_String_List_1_BasicItem_byref_MenuItemLocationData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		locationData = ((num3 == 0) ? null : new MenuItemLocationData(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1398384, RefRangeEnd = 1398388, XrefRangeStart = 1398365, XrefRangeEnd = 1398384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UniTask<bool> LoadXmlFile(string filePath, Il2CppSystem.Action<XmlDocument> fileLoadedCallback, Il2CppSystem.Action<string> fileLoadingErrorCallback)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fileLoadedCallback);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fileLoadingErrorCallback);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadXmlFile_Private_Static_UniTask_1_Boolean_String_Action_1_XmlDocument_Action_1_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new UniTask<bool>(pointer);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1398390, RefRangeEnd = 1398393, XrefRangeStart = 1398388, XrefRangeEnd = 1398390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ReadXmlAttributeString(XmlNode node, string attribute)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(attribute);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadXmlAttributeString_Private_Static_String_XmlNode_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1398397, RefRangeEnd = 1398404, XrefRangeStart = 1398393, XrefRangeEnd = 1398397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ReadXmlAttributeValue(XmlNode node, string attribute)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(attribute);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadXmlAttributeValue_Private_Static_Int32_XmlNode_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398404, XrefRangeEnd = 1398562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnRanksFileLoaded(XmlDocument xmlDoc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)xmlDoc);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnRanksFileLoaded_Private_Void_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1398578, RefRangeEnd = 1398580, XrefRangeStart = 1398562, XrefRangeEnd = 1398578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddAdminFileIfAvailable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddAdminFileIfAvailable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398580, XrefRangeEnd = 1398628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnFileLoaded(XmlDocument xmlDoc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)xmlDoc);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnFileLoaded_Private_Void_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398628, XrefRangeEnd = 1398629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnOverwriteFileLoaded(XmlDocument xmlDoc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)xmlDoc);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnOverwriteFileLoaded_Private_Void_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1398651, RefRangeEnd = 1398652, XrefRangeStart = 1398629, XrefRangeEnd = 1398651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnLoadError(string errorMessage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(errorMessage);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnLoadError_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398652, XrefRangeEnd = 1398690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnRanksLoadError(string errorMessage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(errorMessage);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnRanksLoadError_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AdminMenu(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
