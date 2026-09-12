using System;
using System.Runtime.CompilerServices;
using Il2Cpp;
using Il2CppAnkama.AddressableUtilities.Runtime;
using Il2CppCore.DataCenter;
using Il2CppCore.DataCenter.Interfaces;
using Il2CppCore.UI.Bindings;
using Il2CppCore.UILogic.Bindings;
using Il2CppCysharp.Threading.Tasks;
using Il2CppCysharp.Threading.Tasks.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using UnityEngine.UIElements;

namespace Il2CppCore.UILogic.Admin;

public class AdminSelectItemUI : fzy<AdminSelectItemBinding>
{
	[OriginalName("Core.dll", "", "ResourceType")]
	public enum ResourceType
	{
		Item,
		Monster,
		Look,
		Fireworks,
		Spell,
		Npc,
		Count
	}

	public class ListEntryData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_lowerName;

		private static readonly System.IntPtr NativeFieldInfoPtr_returnData;

		private static readonly System.IntPtr NativeFieldInfoPtr_id;

		private static readonly System.IntPtr NativeFieldInfoPtr_iconId;

		private static readonly System.IntPtr NativeFieldInfoPtr_typeId;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe string name
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string lowerName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowerName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lowerName)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string returnData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_returnData);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_returnData)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe int id
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = num;
			}
		}

		public unsafe int iconId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iconId);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iconId)) = num;
			}
		}

		public unsafe uint typeId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typeId);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typeId)) = num;
			}
		}

		static ListEntryData()
		{
			Il2CppClassPointerStore<ListEntryData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, "ListEntryData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListEntryData>.NativeClassPtr);
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListEntryData>.NativeClassPtr, "name");
			NativeFieldInfoPtr_lowerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListEntryData>.NativeClassPtr, "lowerName");
			NativeFieldInfoPtr_returnData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListEntryData>.NativeClassPtr, "returnData");
			NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListEntryData>.NativeClassPtr, "id");
			NativeFieldInfoPtr_iconId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListEntryData>.NativeClassPtr, "iconId");
			NativeFieldInfoPtr_typeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListEntryData>.NativeClassPtr, "typeId");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListEntryData>.NativeClassPtr, 100710947);
		}

		[CallerCount(8662)]
		[CachedScanResults(RefRangeStart = 12, RefRangeEnd = 8674, XrefRangeStart = 12, XrefRangeEnd = 8674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListEntryData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListEntryData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public ListEntryData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class ResourceTypeData : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_title;

		private static readonly System.IntPtr NativeFieldInfoPtr_replacedTag;

		public unsafe string title
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_title);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_title)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string replacedTag
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_replacedTag);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_replacedTag)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		static ResourceTypeData()
		{
			Il2CppClassPointerStore<ResourceTypeData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, "ResourceTypeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceTypeData>.NativeClassPtr);
			NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceTypeData>.NativeClassPtr, "title");
			NativeFieldInfoPtr_replacedTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceTypeData>.NativeClassPtr, "replacedTag");
		}

		public ResourceTypeData(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public ResourceTypeData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceTypeData>.NativeClassPtr))
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("Core.UILogic.Admin.AdminSelectItemUI+<>c")]
	public new sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__24_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__32_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__32_1;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__InitUi_b__24_0_Internal_Int32_String_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ComputeComparison_b__32_0_Internal_Int32_ListEntryData_ListEntryData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ComputeComparison_b__32_1_Internal_Int32_ListEntryData_ListEntryData_0;

		public unsafe static __c __9
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c));
			}
		}

		public unsafe static Il2CppSystem.Comparison<string> __9__24_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__24_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		public unsafe static Il2CppSystem.Comparison<ListEntryData> __9__32_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__32_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<ListEntryData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__32_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		public unsafe static Il2CppSystem.Comparison<ListEntryData> __9__32_1
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__32_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<ListEntryData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__32_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparison));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__24_0");
			NativeFieldInfoPtr___9__32_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__32_0");
			NativeFieldInfoPtr___9__32_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__32_1");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100710949);
			NativeMethodInfoPtr__InitUi_b__24_0_Internal_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100710950);
			NativeMethodInfoPtr__ComputeComparison_b__32_0_Internal_Int32_ListEntryData_ListEntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100710951);
			NativeMethodInfoPtr__ComputeComparison_b__32_1_Internal_Int32_ListEntryData_ListEntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100710952);
		}

		[CallerCount(8662)]
		[CachedScanResults(RefRangeStart = 12, RefRangeEnd = 8674, XrefRangeStart = 12, XrefRangeEnd = 8674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _InitUi_b__24_0(string lhs, string rhs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(lhs);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(rhs);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__InitUi_b__24_0_Internal_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _ComputeComparison_b__32_0(ListEntryData lhs, ListEntryData rhs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lhs);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rhs);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ComputeComparison_b__32_0_Internal_Int32_ListEntryData_ListEntryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _ComputeComparison_b__32_1(ListEntryData lhs, ListEntryData rhs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lhs);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rhs);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ComputeComparison_b__32_1_Internal_Int32_ListEntryData_ListEntryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("Core.UILogic.Admin.AdminSelectItemUI+<ParseItems>d__33`1")]
	public sealed class _ParseItems_d__33<Entry> : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;

		private static readonly System.IntPtr NativeFieldInfoPtr_entryDataSource;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr__parsedItemCount_5__2;

		private static readonly System.IntPtr NativeFieldInfoPtr__itemList_5__3;

		private static readonly System.IntPtr NativeFieldInfoPtr__idToTypeMap_5__4;

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

		public unsafe AsyncUniTaskVoidMethodBuilder __t__builder
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___t__builder);
				return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asyncUniTaskVoidMethodBuilder)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe MetadataRoot<Entry> entryDataSource
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entryDataSource);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MetadataRoot<Entry>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_entryDataSource)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)metadataRoot));
			}
		}

		public unsafe AdminSelectItemUI __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AdminSelectItemUI>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)adminSelectItemUI));
			}
		}

		public unsafe int _parsedItemCount_5__2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__parsedItemCount_5__2);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__parsedItemCount_5__2)) = num;
			}
		}

		public unsafe List<Entry> _itemList_5__3
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__itemList_5__3);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Entry>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__itemList_5__3)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe Dictionary<uint, string> _idToTypeMap_5__4
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__idToTypeMap_5__4);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<uint, string>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__idToTypeMap_5__4)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
			}
		}

		public unsafe UniTask.Awaiter __u__1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__1);
				return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)awaiter)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static _ParseItems_d__33()
		{
			Il2CppClassPointerStore<_ParseItems_d__33<Entry>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, "<ParseItems>d__33`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Entry>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_ParseItems_d__33<Entry>>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ParseItems_d__33<Entry>>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ParseItems_d__33<Entry>>.NativeClassPtr, "<>t__builder");
			NativeFieldInfoPtr_entryDataSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ParseItems_d__33<Entry>>.NativeClassPtr, "entryDataSource");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ParseItems_d__33<Entry>>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr__parsedItemCount_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ParseItems_d__33<Entry>>.NativeClassPtr, "<parsedItemCount>5__2");
			NativeFieldInfoPtr__itemList_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ParseItems_d__33<Entry>>.NativeClassPtr, "<itemList>5__3");
			NativeFieldInfoPtr__idToTypeMap_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ParseItems_d__33<Entry>>.NativeClassPtr, "<idToTypeMap>5__4");
			NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ParseItems_d__33<Entry>>.NativeClassPtr, "<>u__1");
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_ParseItems_d__33<Entry>>.NativeClassPtr, 100710953);
			NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_ParseItems_d__33<Entry>>.NativeClassPtr, 100710954);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398690, XrefRangeEnd = 1398784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetStateMachine(Il2CppSystem.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stateMachine);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public _ParseItems_d__33(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public _ParseItems_d__33()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_ParseItems_d__33<Entry>>.NativeClassPtr))
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_ParseItems_Private_UniTaskVoid_MetadataRoot_1_Entry_0<Entry>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ParseItems_Private_UniTaskVoid_MetadataRoot_1_Entry_0, Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Entry>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_s_resourceTypesData;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_cachedItems;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_cachedTypes;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_listEntriesBindings;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_currentItems;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_currentTypesToIdMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_unfilteredDataProvider;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_filteredDataProvider;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_iconAddressableEntryType;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_windowTitle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_resourceType;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_itemSelectedCallback;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_openInventory;

	private static readonly System.IntPtr NativeFieldInfoPtr_FireworkTypeId;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_cancellationTokenSource;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_m_isCenteredByDefault_Protected_Virtual_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_m_canTakeFocus_Protected_Virtual_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_VisualElement_fca_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OpenAdminItemSelection_Public_Void_Action_2_String_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitUiBindings_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitUi_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShutdownUi_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindResourceType_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindIconAddressableEntryType_Private_Static_AddressableEntryType_ResourceType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BindItemLine_Private_Void_VisualElement_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnbindItemLine_Private_Void_VisualElement_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateWindowLoadingTitle_Private_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildItemList_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeComparison_Private_Static_Comparison_1_ListEntryData_ResourceType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseItems_Private_UniTaskVoid_MetadataRoot_1_Entry_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShouldSkipItem_Private_Boolean_IAdminSelectionEntry_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateListEntry_Private_ListEntryData_IAdminSelectionEntry_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateListEntries_Private_Void_List_1_ListEntryData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnClickCloseButton_Private_Void_VisualElement_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnSearchTextChanged_Private_Void_ChangeEvent_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnTextFieldFocusIn_Private_Void_FocusInEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnTextFieldFocusOut_Private_Void_FocusOutEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnClickListItem_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnSelectCategory_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnSearchTimerElapsed_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__InitUiBindings_b__23_0_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__BindItemLine_b__28_0_Private_Void_VisualElement_0;

	public unsafe static List<ResourceTypeData> s_resourceTypesData
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_resourceTypesData, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ResourceTypeData>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_resourceTypesData, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<List<ListEntryData>> m_cachedItems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_cachedItems);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<List<ListEntryData>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_cachedItems)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Dictionary<string, uint>> m_cachedTypes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_cachedTypes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Dictionary<string, uint>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_cachedTypes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<int, AdminSelectItemEntryBinding> m_listEntriesBindings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_listEntriesBindings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, AdminSelectItemEntryBinding>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_listEntriesBindings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<ListEntryData> m_currentItems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_currentItems);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ListEntryData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_currentItems)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Dictionary<string, uint> m_currentTypesToIdMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_currentTypesToIdMap);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, uint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_currentTypesToIdMap)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<ListEntryData> m_unfilteredDataProvider
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_unfilteredDataProvider);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ListEntryData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_unfilteredDataProvider)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<ListEntryData> m_filteredDataProvider
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_filteredDataProvider);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ListEntryData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_filteredDataProvider)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe AddressableEntryType m_iconAddressableEntryType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_iconAddressableEntryType);
			return new AddressableEntryType(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AddressableEntryType>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_iconAddressableEntryType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)addressableEntryType)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AddressableEntryType>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe string m_windowTitle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_windowTitle);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_windowTitle)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe ResourceType m_resourceType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_resourceType);
			return *(ResourceType*)num;
		}
		set
		{
			*(ResourceType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_resourceType)) = resourceType;
		}
	}

	public unsafe Il2CppSystem.Action<string, string> m_itemSelectedCallback
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_itemSelectedCallback);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<string, string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_itemSelectedCallback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe bool m_openInventory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_openInventory);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_openInventory)) = flag;
		}
	}

	public unsafe static uint FireworkTypeId
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FireworkTypeId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FireworkTypeId, (void*)(&num));
		}
	}

	public unsafe CancellationTokenSource m_cancellationTokenSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_cancellationTokenSource);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_cancellationTokenSource)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cancellationTokenSource));
		}
	}

	public unsafe override bool m_isCenteredByDefault
	{
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 482957, RefRangeEnd = 482996, XrefRangeStart = 482957, XrefRangeEnd = 482996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_m_isCenteredByDefault_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe override bool m_canTakeFocus
	{
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 482957, RefRangeEnd = 482996, XrefRangeStart = 482957, XrefRangeEnd = 482996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_m_canTakeFocus_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static AdminSelectItemUI()
	{
		Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Core.dll", "Core.UILogic.Admin", "AdminSelectItemUI");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr);
		NativeFieldInfoPtr_s_resourceTypesData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, "s_resourceTypesData");
		NativeFieldInfoPtr_m_cachedItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, "m_cachedItems");
		NativeFieldInfoPtr_m_cachedTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, "m_cachedTypes");
		NativeFieldInfoPtr_m_listEntriesBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, "m_listEntriesBindings");
		NativeFieldInfoPtr_m_currentItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, "m_currentItems");
		NativeFieldInfoPtr_m_currentTypesToIdMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, "m_currentTypesToIdMap");
		NativeFieldInfoPtr_m_unfilteredDataProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, "m_unfilteredDataProvider");
		NativeFieldInfoPtr_m_filteredDataProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, "m_filteredDataProvider");
		NativeFieldInfoPtr_m_iconAddressableEntryType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, "m_iconAddressableEntryType");
		NativeFieldInfoPtr_m_windowTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, "m_windowTitle");
		NativeFieldInfoPtr_m_resourceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, "m_resourceType");
		NativeFieldInfoPtr_m_itemSelectedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, "m_itemSelectedCallback");
		NativeFieldInfoPtr_m_openInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, "m_openInventory");
		NativeFieldInfoPtr_FireworkTypeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, "FireworkTypeId");
		NativeFieldInfoPtr_m_cancellationTokenSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, "m_cancellationTokenSource");
		NativeMethodInfoPtr_get_m_isCenteredByDefault_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, 100710918);
		NativeMethodInfoPtr_get_m_canTakeFocus_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, 100710919);
		NativeMethodInfoPtr__ctor_Public_Void_VisualElement_fca_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, 100710920);
		NativeMethodInfoPtr_OpenAdminItemSelection_Public_Void_Action_2_String_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, 100710921);
		NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, 100710922);
		NativeMethodInfoPtr_InitUiBindings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, 100710923);
		NativeMethodInfoPtr_InitUi_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, 100710924);
		NativeMethodInfoPtr_ShutdownUi_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, 100710925);
		NativeMethodInfoPtr_FindResourceType_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, 100710926);
		NativeMethodInfoPtr_FindIconAddressableEntryType_Private_Static_AddressableEntryType_ResourceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, 100710927);
		NativeMethodInfoPtr_BindItemLine_Private_Void_VisualElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, 100710928);
		NativeMethodInfoPtr_UnbindItemLine_Private_Void_VisualElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, 100710929);
		NativeMethodInfoPtr_UpdateWindowLoadingTitle_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, 100710930);
		NativeMethodInfoPtr_BuildItemList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, 100710931);
		NativeMethodInfoPtr_ComputeComparison_Private_Static_Comparison_1_ListEntryData_ResourceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, 100710932);
		NativeMethodInfoPtr_ParseItems_Private_UniTaskVoid_MetadataRoot_1_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, 100710933);
		NativeMethodInfoPtr_ShouldSkipItem_Private_Boolean_IAdminSelectionEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, 100710934);
		NativeMethodInfoPtr_CreateListEntry_Private_ListEntryData_IAdminSelectionEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, 100710935);
		NativeMethodInfoPtr_UpdateListEntries_Private_Void_List_1_ListEntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, 100710936);
		NativeMethodInfoPtr_OnClickCloseButton_Private_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, 100710937);
		NativeMethodInfoPtr_OnSearchTextChanged_Private_Void_ChangeEvent_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, 100710938);
		NativeMethodInfoPtr_OnTextFieldFocusIn_Private_Void_FocusInEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, 100710939);
		NativeMethodInfoPtr_OnTextFieldFocusOut_Private_Void_FocusOutEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, 100710940);
		NativeMethodInfoPtr_OnClickListItem_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, 100710941);
		NativeMethodInfoPtr_OnSelectCategory_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, 100710942);
		NativeMethodInfoPtr_OnSearchTimerElapsed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, 100710943);
		NativeMethodInfoPtr__InitUiBindings_b__23_0_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, 100710945);
		NativeMethodInfoPtr__BindItemLine_b__28_0_Private_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr, 100710946);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1398844, RefRangeEnd = 1398848, XrefRangeStart = 1398784, XrefRangeEnd = 1398844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AdminSelectItemUI(VisualElement root, fca dependenciesService)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdminSelectItemUI>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)root);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dependenciesService);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_VisualElement_fca_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1398865, RefRangeEnd = 1398869, XrefRangeStart = 1398848, XrefRangeEnd = 1398865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OpenAdminItemSelection(Il2CppSystem.Action<string, string> itemSelectedCallback, string command, bool openInventory)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemSelectedCallback);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(command);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &openInventory;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenAdminItemSelection_Public_Void_Action_2_String_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398869, XrefRangeEnd = 1398873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1398944, RefRangeEnd = 1398945, XrefRangeStart = 1398873, XrefRangeEnd = 1398944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitUiBindings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitUiBindings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1399004, RefRangeEnd = 1399006, XrefRangeStart = 1398945, XrefRangeEnd = 1399004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitUi()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitUi_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShutdownUi()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShutdownUi_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1399037, RefRangeEnd = 1399038, XrefRangeStart = 1399006, XrefRangeEnd = 1399037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FindResourceType(string command)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(command);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindResourceType_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399038, XrefRangeEnd = 1399039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AddressableEntryType FindIconAddressableEntryType(ResourceType resourceType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&resourceType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindIconAddressableEntryType_Private_Static_AddressableEntryType_ResourceType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new AddressableEntryType(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399039, XrefRangeEnd = 1399074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BindItemLine(VisualElement element, int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)element);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BindItemLine_Private_Void_VisualElement_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399074, XrefRangeEnd = 1399085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnbindItemLine(VisualElement element, int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)element);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnbindItemLine_Private_Void_VisualElement_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1399098, RefRangeEnd = 1399099, XrefRangeStart = 1399085, XrefRangeEnd = 1399098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateWindowLoadingTitle(int parsedItemCount, int totalItemCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&parsedItemCount);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &totalItemCount;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateWindowLoadingTitle_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399099, XrefRangeEnd = 1399125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuildItemList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildItemList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1399139, RefRangeEnd = 1399140, XrefRangeStart = 1399125, XrefRangeEnd = 1399139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Comparison<ListEntryData> ComputeComparison(ResourceType resourceType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&resourceType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeComparison_Private_Static_Comparison_1_ListEntryData_ResourceType_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<ListEntryData>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1399142, RefRangeEnd = 1399143, XrefRangeStart = 1399140, XrefRangeEnd = 1399142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UniTaskVoid ParseItems<Entry>(MetadataRoot<Entry> entryDataSource)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entryDataSource);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ParseItems_Private_UniTaskVoid_MetadataRoot_1_Entry_0<Entry>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(UniTaskVoid*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1399144, RefRangeEnd = 1399145, XrefRangeStart = 1399143, XrefRangeEnd = 1399144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ShouldSkipItem(IAdminSelectionEntry entry)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entry);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShouldSkipItem_Private_Boolean_IAdminSelectionEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1399174, RefRangeEnd = 1399175, XrefRangeStart = 1399145, XrefRangeEnd = 1399174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ListEntryData CreateListEntry(IAdminSelectionEntry entry)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)entry);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateListEntry_Private_ListEntryData_IAdminSelectionEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ListEntryData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399175, XrefRangeEnd = 1399178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateListEntries(List<ListEntryData> itemList)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemList);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateListEntries_Private_Void_List_1_ListEntryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399178, XrefRangeEnd = 1399191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnClickCloseButton(VisualElement visualElement)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)visualElement);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnClickCloseButton_Private_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399191, XrefRangeEnd = 1399207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSearchTextChanged(ChangeEvent<string> _)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnSearchTextChanged_Private_Void_ChangeEvent_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399207, XrefRangeEnd = 1399218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnTextFieldFocusIn(FocusInEvent evt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)evt);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnTextFieldFocusIn_Private_Void_FocusInEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399218, XrefRangeEnd = 1399229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnTextFieldFocusOut(FocusOutEvent evt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)evt);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnTextFieldFocusOut_Private_Void_FocusOutEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1399234, RefRangeEnd = 1399236, XrefRangeStart = 1399229, XrefRangeEnd = 1399234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnClickListItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnClickListItem_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399236, XrefRangeEnd = 1399268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSelectCategory(string selectedCategory)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(selectedCategory);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnSelectCategory_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399268, XrefRangeEnd = 1399302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSearchTimerElapsed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnSearchTimerElapsed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399302, XrefRangeEnd = 1399303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _InitUiBindings_b__23_0(int _)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__InitUiBindings_b__23_0_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _BindItemLine_b__28_0(VisualElement elem)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)elem);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__BindItemLine_b__28_0_Private_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AdminSelectItemUI(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
