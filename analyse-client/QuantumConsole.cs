using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppQFSW.QC.Pooling;
using Il2CppQFSW.QC.UI;
using Il2CppQFSW.QC.Utilities;
using Il2CppQFSW.QC.Utilities.Commands;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Text;
using Il2CppSystem.Text.RegularExpressions;
using Il2CppSystem.Threading.Tasks;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppQFSW.QC;

public class QuantumConsole : MonoBehaviour
{
	[ObfuscatedName("QFSW.QC.QuantumConsole+<InvokeCommandsAsync>d__188")]
	public sealed class _InvokeCommandsAsync_d__188 : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;

		private static readonly System.IntPtr NativeFieldInfoPtr_commands;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap1;

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

		public unsafe Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___t__builder);
				return new Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asyncTaskMethodBuilder)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe IEnumerable<string> commands
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commands);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commands)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)enumerable));
			}
		}

		public unsafe QuantumConsole __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<QuantumConsole>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)quantumConsole));
			}
		}

		public unsafe IEnumerator<string> __7__wrap1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___7__wrap1);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator<string>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___7__wrap1)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)enumerator));
			}
		}

		public unsafe Il2CppSystem.Runtime.CompilerServices.TaskAwaiter __u__1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__1);
				return new Il2CppSystem.Runtime.CompilerServices.TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.TaskAwaiter>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)taskAwaiter)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.TaskAwaiter>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static _InvokeCommandsAsync_d__188()
		{
			Il2CppClassPointerStore<_InvokeCommandsAsync_d__188>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "<InvokeCommandsAsync>d__188");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_InvokeCommandsAsync_d__188>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_InvokeCommandsAsync_d__188>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_InvokeCommandsAsync_d__188>.NativeClassPtr, "<>t__builder");
			NativeFieldInfoPtr_commands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_InvokeCommandsAsync_d__188>.NativeClassPtr, "commands");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_InvokeCommandsAsync_d__188>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_InvokeCommandsAsync_d__188>.NativeClassPtr, "<>7__wrap1");
			NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_InvokeCommandsAsync_d__188>.NativeClassPtr, "<>u__1");
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_InvokeCommandsAsync_d__188>.NativeClassPtr, 100663669);
			NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_InvokeCommandsAsync_d__188>.NativeClassPtr, 100663670);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814360, XrefRangeEnd = 2814396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814396, XrefRangeEnd = 2814400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetStateMachine(Il2CppSystem.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stateMachine);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public _InvokeCommandsAsync_d__188(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public _InvokeCommandsAsync_d__188()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_InvokeCommandsAsync_d__188>.NativeClassPtr))
		{
		}
	}

	[ObfuscatedName("QFSW.QC.QuantumConsole+<InvokeExternalCommandsAsync>d__187")]
	public sealed class _InvokeExternalCommandsAsync_d__187 : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;

		private static readonly System.IntPtr NativeFieldInfoPtr_filePath;

		private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

		private static readonly System.IntPtr NativeFieldInfoPtr__reader_5__2;

		private static readonly System.IntPtr NativeFieldInfoPtr___u__1;

		private static readonly System.IntPtr NativeFieldInfoPtr___u__2;

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

		public unsafe Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder __t__builder
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___t__builder);
				return new Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asyncTaskMethodBuilder)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder>.NativeClassPtr, ref *(uint*)null));
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

		public unsafe QuantumConsole __4__this
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<QuantumConsole>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___4__this)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)quantumConsole));
			}
		}

		public unsafe StreamReader _reader_5__2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__reader_5__2);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StreamReader>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__reader_5__2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)streamReader));
			}
		}

		public unsafe Il2CppSystem.Runtime.CompilerServices.TaskAwaiter<string> __u__1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__1);
				return new Il2CppSystem.Runtime.CompilerServices.TaskAwaiter<string>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.TaskAwaiter<string>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)taskAwaiter)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.TaskAwaiter<string>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe Il2CppSystem.Runtime.CompilerServices.TaskAwaiter __u__2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__2);
				return new Il2CppSystem.Runtime.CompilerServices.TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.TaskAwaiter>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)taskAwaiter)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Runtime.CompilerServices.TaskAwaiter>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static _InvokeExternalCommandsAsync_d__187()
		{
			Il2CppClassPointerStore<_InvokeExternalCommandsAsync_d__187>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "<InvokeExternalCommandsAsync>d__187");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_InvokeExternalCommandsAsync_d__187>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_InvokeExternalCommandsAsync_d__187>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_InvokeExternalCommandsAsync_d__187>.NativeClassPtr, "<>t__builder");
			NativeFieldInfoPtr_filePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_InvokeExternalCommandsAsync_d__187>.NativeClassPtr, "filePath");
			NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_InvokeExternalCommandsAsync_d__187>.NativeClassPtr, "<>4__this");
			NativeFieldInfoPtr__reader_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_InvokeExternalCommandsAsync_d__187>.NativeClassPtr, "<reader>5__2");
			NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_InvokeExternalCommandsAsync_d__187>.NativeClassPtr, "<>u__1");
			NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_InvokeExternalCommandsAsync_d__187>.NativeClassPtr, "<>u__2");
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_InvokeExternalCommandsAsync_d__187>.NativeClassPtr, 100663671);
			NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_InvokeExternalCommandsAsync_d__187>.NativeClassPtr, 100663672);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814400, XrefRangeEnd = 2814450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814450, XrefRangeEnd = 2814454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetStateMachine(Il2CppSystem.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stateMachine);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public _InvokeExternalCommandsAsync_d__187(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public _InvokeExternalCommandsAsync_d__187()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_InvokeExternalCommandsAsync_d__187>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__Instance_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__canvasScaler;

	private static readonly System.IntPtr NativeFieldInfoPtr__containerRect;

	private static readonly System.IntPtr NativeFieldInfoPtr__scrollRect;

	private static readonly System.IntPtr NativeFieldInfoPtr__suggestionPopupTopRect;

	private static readonly System.IntPtr NativeFieldInfoPtr__suggestionPopupBttmRect;

	private static readonly System.IntPtr NativeFieldInfoPtr__jobCounterRect;

	private static readonly System.IntPtr NativeFieldInfoPtr__panels;

	private static readonly System.IntPtr NativeFieldInfoPtr__theme;

	private static readonly System.IntPtr NativeFieldInfoPtr__keyConfig;

	private static readonly System.IntPtr NativeFieldInfoPtr__localization;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnSendToServer;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnSendToClient;

	private static readonly System.IntPtr NativeFieldInfoPtr__lastCommandIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr__commandQueue;

	private static readonly System.IntPtr NativeFieldInfoPtr__currentCommand;

	private static readonly System.IntPtr NativeFieldInfoPtr_ClientCommandPrefix;

	private static readonly System.IntPtr NativeFieldInfoPtr__commandHistoryFilePath;

	private static readonly System.IntPtr NativeFieldInfoPtr_InputFieldBlockingFieldName;

	private static readonly System.IntPtr NativeFieldInfoPtr__HasMouseOver_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_LockScroll;

	private static readonly System.IntPtr NativeFieldInfoPtr_AutoComplete;

	private static readonly System.IntPtr NativeFieldInfoPtr_openConsoleOnMessage;

	private static readonly System.IntPtr NativeFieldInfoPtr__currentCommandResult;

	private static readonly System.IntPtr NativeFieldInfoPtr__lastStartingCommandHistoryProcessTime;

	private static readonly System.IntPtr NativeFieldInfoPtr__lastProcessCommandHistoryTime;

	private static readonly System.IntPtr NativeFieldInfoPtr__isProcessingCommandHistory;

	private static readonly System.IntPtr NativeFieldInfoPtr__startingTimeForContinuouslyProcessingCommandHistory;

	private static readonly System.IntPtr NativeFieldInfoPtr__minTimeBeforeProcessingCommandHistory;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_specialPasteHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr__IsHistoryInitialized_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__hyperlinksRegex;

	private static readonly System.IntPtr NativeFieldInfoPtr_linkHashes;

	private static readonly System.IntPtr NativeFieldInfoPtr__enableChainedCommands;

	private static readonly System.IntPtr NativeFieldInfoPtr__saveHistoryToCache;

	private static readonly System.IntPtr NativeFieldInfoPtr__maxSavedHistorySize;

	private static readonly System.IntPtr NativeFieldInfoPtr__verboseErrors;

	private static readonly System.IntPtr NativeFieldInfoPtr__verboseLogging;

	private static readonly System.IntPtr NativeFieldInfoPtr__loggingLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr__openOnLogLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr__interceptDebugLogger;

	private static readonly System.IntPtr NativeFieldInfoPtr__interceptWhilstInactive;

	private static readonly System.IntPtr NativeFieldInfoPtr__prependTimestamps;

	private static readonly System.IntPtr NativeFieldInfoPtr__supportedState;

	private static readonly System.IntPtr NativeFieldInfoPtr__activateOnStartup;

	private static readonly System.IntPtr NativeFieldInfoPtr__initialiseOnStartup;

	private static readonly System.IntPtr NativeFieldInfoPtr__closeOnSubmit;

	private static readonly System.IntPtr NativeFieldInfoPtr__singletonMode;

	private static readonly System.IntPtr NativeFieldInfoPtr__autoScroll;

	private static readonly System.IntPtr NativeFieldInfoPtr__enableAutocomplete;

	private static readonly System.IntPtr NativeFieldInfoPtr__showPopupDisplay;

	private static readonly System.IntPtr NativeFieldInfoPtr__suggestionDisplayOrder;

	private static readonly System.IntPtr NativeFieldInfoPtr__maxSuggestionDisplaySize;

	private static readonly System.IntPtr NativeFieldInfoPtr__useFuzzySearch;

	private static readonly System.IntPtr NativeFieldInfoPtr__caseSensitiveSearch;

	private static readonly System.IntPtr NativeFieldInfoPtr__collapseSuggestionOverloads;

	private static readonly System.IntPtr NativeFieldInfoPtr__showCurrentJobs;

	private static readonly System.IntPtr NativeFieldInfoPtr__blockOnAsync;

	private static readonly System.IntPtr NativeFieldInfoPtr__storeCommandHistory;

	private static readonly System.IntPtr NativeFieldInfoPtr__storeDuplicateCommands;

	private static readonly System.IntPtr NativeFieldInfoPtr__storeAdjacentDuplicateCommands;

	private static readonly System.IntPtr NativeFieldInfoPtr__commandHistorySize;

	private static readonly System.IntPtr NativeFieldInfoPtr__maxStoredLogs;

	private static readonly System.IntPtr NativeFieldInfoPtr__maxLogSize;

	private static readonly System.IntPtr NativeFieldInfoPtr__showInitLogs;

	private static readonly System.IntPtr NativeFieldInfoPtr__consoleInput;

	private static readonly System.IntPtr NativeFieldInfoPtr__inputPlaceholderText;

	private static readonly System.IntPtr NativeFieldInfoPtr__consoleLogText;

	private static readonly System.IntPtr NativeFieldInfoPtr__consoleSuggestionText;

	private static readonly System.IntPtr NativeFieldInfoPtr__suggestionPopupTopText;

	private static readonly System.IntPtr NativeFieldInfoPtr__suggestionPopupBttmText;

	private static readonly System.IntPtr NativeFieldInfoPtr__jobCounterText;

	private static readonly System.IntPtr NativeFieldInfoPtr__serverName;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnStateChange;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnInvoke;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnClear;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnLog;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnActivate;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnDeactivate;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnSuggestionSetGenerated;

	private static readonly System.IntPtr NativeFieldInfoPtr__serializer;

	private static readonly System.IntPtr NativeFieldInfoPtr__suggestionStack;

	private static readonly System.IntPtr NativeFieldInfoPtr__logStorage;

	private static readonly System.IntPtr NativeFieldInfoPtr__logQueue;

	private static readonly System.IntPtr NativeFieldInfoPtr__IsActive_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__previousCommands;

	private static readonly System.IntPtr NativeFieldInfoPtr__currentTasks;

	private static readonly System.IntPtr NativeFieldInfoPtr__currentActions;

	private static readonly System.IntPtr NativeFieldInfoPtr__stringBuilderPool;

	private static readonly System.IntPtr NativeFieldInfoPtr__selectedPreviousCommandIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr__currentInput;

	private static readonly System.IntPtr NativeFieldInfoPtr__previousInput;

	private static readonly System.IntPtr NativeFieldInfoPtr__isGeneratingTable;

	private static readonly System.IntPtr NativeFieldInfoPtr__consoleRequiresFlush;

	private static readonly System.IntPtr NativeFieldInfoPtr__textComponents;

	private static readonly System.IntPtr NativeFieldInfoPtr__voidTaskType;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_QuantumConsole_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_QuantumConsole_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Theme_Public_get_QuantumTheme_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_OnSendToServer_Private_Static_add_Void_Action_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnSendToServer_Private_Static_rem_Void_Action_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_OnSendToClient_Public_Static_add_Void_Action_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnSendToClient_Public_Static_rem_Void_Action_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_KeyConfig_Public_get_QuantumKeyConfig_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_KeyConfig_Public_set_Void_QuantumKeyConfig_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Localization_Public_get_QuantumLocalization_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Localization_Public_set_Void_QuantumLocalization_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSendToServerCallback_Public_Static_Void_Action_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveSendToServerCallback_Public_Static_Void_Action_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSendToClientCallback_Public_Static_Void_Action_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveSendToClientCallback_Public_Static_Void_Action_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveFromServer_Public_Void_CommandResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasMouseOver_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_HasMouseOver_Private_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get__isResult_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsHistoryInitialized_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_IsHistoryInitialized_Private_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_logFilePath_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCommands_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxStoredLogs_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_MaxStoredLogs_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_OnStateChange_Public_add_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnStateChange_Public_rem_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_OnInvoke_Public_add_Void_Action_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnInvoke_Public_rem_Void_Action_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_OnClear_Public_add_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnClear_Public_rem_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_OnLog_Public_add_Void_Action_1_ILog_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnLog_Public_rem_Void_Action_1_ILog_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_OnActivate_Public_add_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnActivate_Public_rem_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_OnDeactivate_Public_add_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnDeactivate_Public_rem_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_OnSuggestionSetGenerated_Public_add_Void_Action_1_SuggestionSet_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnSuggestionSetGenerated_Public_rem_Void_Action_1_SuggestionSet_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsBlockedByCommands_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsBlockedByAsync_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_IsActive_Private_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsFocused_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AreActionsExecuting_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyTheme_Public_Void_QuantumTheme_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTableGenerationText_Private_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessCommandHistory_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSuggestions_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessAutocomplete_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatSuggestion_Private_Void_IQcSuggestion_Boolean_StringBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFormattedSuggestions_Private_String_SuggestionSet_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFormattedSuggestions_Private_Void_SuggestionSet_StringBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePopupDisplay_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSuggestion_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSuggestionText_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OverrideConsoleInput_Public_Void_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FocusConsoleInput_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnInputChange_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearHistoricalSuggestions_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearSuggestions_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearPopup_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeCommand_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessCommandInput_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessCommandInput_Public_Void_String_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConsumeResult_Private_CommandResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateCommandLog_Protected_ILog_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleCommandResult_Private_Void_CommandResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleNextCommand_Public_Void_CommandResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearChainedCommands_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessCommands_Public_Void_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeCommand_Public_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendToClient_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeExternalCommandsAsync_Public_Task_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeCommandsAsync_Public_Task_IEnumerable_1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetErrorMessage_Private_String_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInvocationErrorMessage_Private_String_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetErrorMessage_Private_String_Exception_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LogToConsoleAsync_Public_Void_String_LogType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LogToConsoleAsync_Public_Void_ILog_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FlushQueuedLogs_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessAsyncTasks_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartAction_Public_Void_IEnumerator_1_ICommandAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CancelAllActions_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessActions_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleAsyncJobCounter_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LogToConsole_Public_Void_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseHyperlinksFromLog_Private_ILog_ILog_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnescapeHTMLCharacters_Private_ILog_ILog_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseHTMLBulletLists_Private_ILog_ILog_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReplaceLink_Private_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LogToConsole_Public_Void_ILog_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FlushToConsoleText_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleIndexOutOfRangeExceptionDuringFlush_Private_Void_IndexOutOfRangeException_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TruncateLog_Private_ILog_ILog_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AppendLog_Protected_Void_ILog_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RequireFlush_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveLogTrace_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetScrollBarValue_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScrollConsoleTo_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForceConsoleTextUpdate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckScrollBarVisibilityNeeded_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScrollConsoleToLatest_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StoreCommand_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearConsole_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetConsoleText_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearBuffers_Protected_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSupportedState_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableQC_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeCommandHistory_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeSuggestionStack_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeLogging_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetServerName_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateLogStorage_Protected_Virtual_New_ILogStorage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateLogQueue_Protected_Virtual_New_ILogQueue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateSuggestionStack_Protected_Virtual_New_SuggestionStack_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Toggle_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Activate_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deactivate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DebugIntercept_Private_Void_String_String_LogType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConstructDebugLog_Protected_Virtual_New_ILog_String_String_LogType_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ParseHyperlinksFromLog_b__202_0_Private_String_Match_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Boolean_String_0;

	public unsafe static QuantumConsole _Instance_k__BackingField
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Instance_k__BackingField, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<QuantumConsole>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Instance_k__BackingField, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)quantumConsole));
		}
	}

	public unsafe DynamicCanvasScaler _canvasScaler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__canvasScaler);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DynamicCanvasScaler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__canvasScaler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dynamicCanvasScaler));
		}
	}

	public unsafe RectTransform _containerRect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__containerRect);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__containerRect)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe Scrollbar _scrollRect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__scrollRect);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__scrollRect)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scrollbar));
		}
	}

	public unsafe RectTransform _suggestionPopupTopRect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__suggestionPopupTopRect);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__suggestionPopupTopRect)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe RectTransform _suggestionPopupBttmRect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__suggestionPopupBttmRect);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__suggestionPopupBttmRect)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe RectTransform _jobCounterRect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__jobCounterRect);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__jobCounterRect)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rectTransform));
		}
	}

	public unsafe Il2CppReferenceArray<Image> _panels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__panels);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Image>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__panels)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe QuantumTheme _theme
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__theme);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<QuantumTheme>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__theme)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)quantumTheme));
		}
	}

	public unsafe QuantumKeyConfig _keyConfig
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__keyConfig);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<QuantumKeyConfig>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__keyConfig)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)quantumKeyConfig));
		}
	}

	public unsafe QuantumLocalization _localization
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__localization);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<QuantumLocalization>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__localization)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)quantumLocalization));
		}
	}

	public unsafe static Il2CppSystem.Action<string> OnSendToServer
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OnSendToServer, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OnSendToServer, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe static Il2CppSystem.Action<string> OnSendToClient
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OnSendToClient, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OnSendToClient, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe int _lastCommandIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastCommandIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastCommandIndex)) = num;
		}
	}

	public unsafe Queue<CommandDescr> _commandQueue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__commandQueue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Queue<CommandDescr>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__commandQueue)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)queue));
		}
	}

	public unsafe CommandDescr _currentCommand
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentCommand);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CommandDescr>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentCommand)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)commandDescr));
		}
	}

	public unsafe static char ClientCommandPrefix
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out char result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ClientCommandPrefix, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ClientCommandPrefix, (void*)(&c));
		}
	}

	public unsafe string _commandHistoryFilePath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__commandHistoryFilePath);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__commandHistoryFilePath)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string InputFieldBlockingFieldName
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_InputFieldBlockingFieldName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_InputFieldBlockingFieldName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static bool _HasMouseOver_k__BackingField
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__HasMouseOver_k__BackingField, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__HasMouseOver_k__BackingField, (void*)(&flag));
		}
	}

	public unsafe static bool LockScroll
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LockScroll, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LockScroll, (void*)(&flag));
		}
	}

	public unsafe static bool AutoComplete
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AutoComplete, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AutoComplete, (void*)(&flag));
		}
	}

	public unsafe static bool openConsoleOnMessage
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_openConsoleOnMessage, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_openConsoleOnMessage, (void*)(&flag));
		}
	}

	public unsafe CommandResult _currentCommandResult
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentCommandResult);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CommandResult>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentCommandResult)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)commandResult));
		}
	}

	public unsafe float _lastStartingCommandHistoryProcessTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastStartingCommandHistoryProcessTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastStartingCommandHistoryProcessTime)) = num;
		}
	}

	public unsafe float _lastProcessCommandHistoryTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastProcessCommandHistoryTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__lastProcessCommandHistoryTime)) = num;
		}
	}

	public unsafe bool _isProcessingCommandHistory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isProcessingCommandHistory);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isProcessingCommandHistory)) = flag;
		}
	}

	public unsafe float _startingTimeForContinuouslyProcessingCommandHistory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__startingTimeForContinuouslyProcessingCommandHistory);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__startingTimeForContinuouslyProcessingCommandHistory)) = num;
		}
	}

	public unsafe float _minTimeBeforeProcessingCommandHistory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__minTimeBeforeProcessingCommandHistory);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__minTimeBeforeProcessingCommandHistory)) = num;
		}
	}

	public unsafe SpecialPasteHandler m_specialPasteHandler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_specialPasteHandler);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SpecialPasteHandler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_specialPasteHandler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)specialPasteHandler));
		}
	}

	public unsafe bool _IsHistoryInitialized_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsHistoryInitialized_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsHistoryInitialized_k__BackingField)) = flag;
		}
	}

	public unsafe Regex _hyperlinksRegex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hyperlinksRegex);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Regex>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hyperlinksRegex)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)regex));
		}
	}

	public unsafe Dictionary<string, string> linkHashes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linkHashes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linkHashes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe bool _enableChainedCommands
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__enableChainedCommands);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__enableChainedCommands)) = flag;
		}
	}

	public unsafe bool _saveHistoryToCache
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__saveHistoryToCache);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__saveHistoryToCache)) = flag;
		}
	}

	public unsafe uint _maxSavedHistorySize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maxSavedHistorySize);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maxSavedHistorySize)) = num;
		}
	}

	public unsafe bool _verboseErrors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__verboseErrors);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__verboseErrors)) = flag;
		}
	}

	public unsafe LoggingThreshold _verboseLogging
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__verboseLogging);
			return *(LoggingThreshold*)num;
		}
		set
		{
			*(LoggingThreshold*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__verboseLogging)) = loggingThreshold;
		}
	}

	public unsafe LoggingThreshold _loggingLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__loggingLevel);
			return *(LoggingThreshold*)num;
		}
		set
		{
			*(LoggingThreshold*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__loggingLevel)) = loggingThreshold;
		}
	}

	public unsafe LoggingThreshold _openOnLogLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__openOnLogLevel);
			return *(LoggingThreshold*)num;
		}
		set
		{
			*(LoggingThreshold*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__openOnLogLevel)) = loggingThreshold;
		}
	}

	public unsafe bool _interceptDebugLogger
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__interceptDebugLogger);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__interceptDebugLogger)) = flag;
		}
	}

	public unsafe bool _interceptWhilstInactive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__interceptWhilstInactive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__interceptWhilstInactive)) = flag;
		}
	}

	public unsafe bool _prependTimestamps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__prependTimestamps);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__prependTimestamps)) = flag;
		}
	}

	public unsafe SupportedState _supportedState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__supportedState);
			return *(SupportedState*)num;
		}
		set
		{
			*(SupportedState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__supportedState)) = supportedState;
		}
	}

	public unsafe bool _activateOnStartup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__activateOnStartup);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__activateOnStartup)) = flag;
		}
	}

	public unsafe bool _initialiseOnStartup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__initialiseOnStartup);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__initialiseOnStartup)) = flag;
		}
	}

	public unsafe bool _closeOnSubmit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__closeOnSubmit);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__closeOnSubmit)) = flag;
		}
	}

	public unsafe bool _singletonMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__singletonMode);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__singletonMode)) = flag;
		}
	}

	public unsafe AutoScrollOptions _autoScroll
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__autoScroll);
			return *(AutoScrollOptions*)num;
		}
		set
		{
			*(AutoScrollOptions*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__autoScroll)) = autoScrollOptions;
		}
	}

	public unsafe bool _enableAutocomplete
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__enableAutocomplete);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__enableAutocomplete)) = flag;
		}
	}

	public unsafe bool _showPopupDisplay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showPopupDisplay);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showPopupDisplay)) = flag;
		}
	}

	public unsafe SortOrder _suggestionDisplayOrder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__suggestionDisplayOrder);
			return *(SortOrder*)num;
		}
		set
		{
			*(SortOrder*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__suggestionDisplayOrder)) = sortOrder;
		}
	}

	public unsafe int _maxSuggestionDisplaySize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maxSuggestionDisplaySize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maxSuggestionDisplaySize)) = num;
		}
	}

	public unsafe bool _useFuzzySearch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__useFuzzySearch);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__useFuzzySearch)) = flag;
		}
	}

	public unsafe bool _caseSensitiveSearch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__caseSensitiveSearch);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__caseSensitiveSearch)) = flag;
		}
	}

	public unsafe bool _collapseSuggestionOverloads
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__collapseSuggestionOverloads);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__collapseSuggestionOverloads)) = flag;
		}
	}

	public unsafe bool _showCurrentJobs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showCurrentJobs);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showCurrentJobs)) = flag;
		}
	}

	public unsafe bool _blockOnAsync
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__blockOnAsync);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__blockOnAsync)) = flag;
		}
	}

	public unsafe bool _storeCommandHistory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__storeCommandHistory);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__storeCommandHistory)) = flag;
		}
	}

	public unsafe bool _storeDuplicateCommands
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__storeDuplicateCommands);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__storeDuplicateCommands)) = flag;
		}
	}

	public unsafe bool _storeAdjacentDuplicateCommands
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__storeAdjacentDuplicateCommands);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__storeAdjacentDuplicateCommands)) = flag;
		}
	}

	public unsafe int _commandHistorySize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__commandHistorySize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__commandHistorySize)) = num;
		}
	}

	public unsafe int _maxStoredLogs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maxStoredLogs);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maxStoredLogs)) = num;
		}
	}

	public unsafe int _maxLogSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maxLogSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maxLogSize)) = num;
		}
	}

	public unsafe bool _showInitLogs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showInitLogs);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__showInitLogs)) = flag;
		}
	}

	public unsafe TMP_InputField _consoleInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__consoleInput);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__consoleInput)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tMP_InputField));
		}
	}

	public unsafe TextMeshProUGUI _inputPlaceholderText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputPlaceholderText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inputPlaceholderText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe TMP_InputField _consoleLogText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__consoleLogText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__consoleLogText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tMP_InputField));
		}
	}

	public unsafe TextMeshProUGUI _consoleSuggestionText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__consoleSuggestionText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__consoleSuggestionText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe TextMeshProUGUI _suggestionPopupTopText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__suggestionPopupTopText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__suggestionPopupTopText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe TextMeshProUGUI _suggestionPopupBttmText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__suggestionPopupBttmText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__suggestionPopupBttmText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe TextMeshProUGUI _jobCounterText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__jobCounterText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__jobCounterText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe TextMeshProUGUI _serverName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__serverName);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__serverName)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textMeshProUGUI));
		}
	}

	public unsafe Il2CppSystem.Action OnStateChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnStateChange);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnStateChange)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe Il2CppSystem.Action<string> OnInvoke
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnInvoke);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnInvoke)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe Il2CppSystem.Action OnClear
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnClear);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnClear)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe Il2CppSystem.Action<ILog> OnLog
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnLog);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<ILog>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnLog)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe Il2CppSystem.Action OnActivate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnActivate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnActivate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe Il2CppSystem.Action OnDeactivate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnDeactivate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnDeactivate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe Il2CppSystem.Action<SuggestionSet> OnSuggestionSetGenerated
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnSuggestionSetGenerated);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<SuggestionSet>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnSuggestionSetGenerated)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe QuantumSerializer _serializer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__serializer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<QuantumSerializer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__serializer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)quantumSerializer));
		}
	}

	public unsafe SuggestionStack _suggestionStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__suggestionStack);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SuggestionStack>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__suggestionStack)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)suggestionStack));
		}
	}

	public unsafe ILogStorage _logStorage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__logStorage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ILogStorage>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__logStorage)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)logStorage));
		}
	}

	public unsafe ILogQueue _logQueue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__logQueue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ILogQueue>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__logQueue)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)logQueue));
		}
	}

	public unsafe bool _IsActive_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsActive_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsActive_k__BackingField)) = flag;
		}
	}

	public unsafe List<string> _previousCommands
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__previousCommands);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__previousCommands)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<Task> _currentTasks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentTasks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Task>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentTasks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe List<IEnumerator<ICommandAction>> _currentActions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentActions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<IEnumerator<ICommandAction>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentActions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe StringBuilderPool _stringBuilderPool
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__stringBuilderPool);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StringBuilderPool>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__stringBuilderPool)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stringBuilderPool));
		}
	}

	public unsafe int _selectedPreviousCommandIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__selectedPreviousCommandIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__selectedPreviousCommandIndex)) = num;
		}
	}

	public unsafe string _currentInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentInput);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentInput)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string _previousInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__previousInput);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__previousInput)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe bool _isGeneratingTable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isGeneratingTable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isGeneratingTable)) = flag;
		}
	}

	public unsafe bool _consoleRequiresFlush
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__consoleRequiresFlush);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__consoleRequiresFlush)) = flag;
		}
	}

	public unsafe Il2CppReferenceArray<TextMeshProUGUI> _textComponents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__textComponents);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMeshProUGUI>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__textComponents)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppSystem.Type _voidTaskType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__voidTaskType);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__voidTaskType)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type));
		}
	}

	public unsafe static QuantumConsole Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814454, XrefRangeEnd = 2814458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_QuantumConsole_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<QuantumConsole>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814458, XrefRangeEnd = 2814462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_QuantumConsole_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe QuantumTheme Theme
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 128343, RefRangeEnd = 128346, XrefRangeStart = 128343, XrefRangeEnd = 128346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Theme_Public_get_QuantumTheme_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<QuantumTheme>(intPtr) : null;
		}
	}

	public unsafe QuantumKeyConfig KeyConfig
	{
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 72304, RefRangeEnd = 72352, XrefRangeStart = 72304, XrefRangeEnd = 72352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_KeyConfig_Public_get_QuantumKeyConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<QuantumKeyConfig>(intPtr) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131292, RefRangeEnd = 131293, XrefRangeStart = 131292, XrefRangeEnd = 131293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_KeyConfig_Public_set_Void_QuantumKeyConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe QuantumLocalization Localization
	{
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 101582, RefRangeEnd = 101601, XrefRangeStart = 101582, XrefRangeEnd = 101601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Localization_Public_get_QuantumLocalization_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<QuantumLocalization>(intPtr) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Localization_Public_set_Void_QuantumLocalization_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe static bool HasMouseOver
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814582, XrefRangeEnd = 2814586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasMouseOver_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814586, XrefRangeEnd = 2814590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_HasMouseOver_Private_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool _isResult
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get__isResult_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool IsHistoryInitialized
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsHistoryInitialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsHistoryInitialized_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe string logFilePath
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814590, XrefRangeEnd = 2814594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_logFilePath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	public unsafe int MaxStoredLogs
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MaxStoredLogs_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814619, XrefRangeEnd = 2814625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_MaxStoredLogs_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool IsBlockedByCommands
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814687, XrefRangeEnd = 2814690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsBlockedByCommands_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool IsBlockedByAsync
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814690, XrefRangeEnd = 2814695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsBlockedByAsync_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool IsActive
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsActive_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool IsFocused
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 2814695, RefRangeEnd = 2814696, XrefRangeStart = 2814695, XrefRangeEnd = 2814695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsFocused_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe bool AreActionsExecuting
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814696, XrefRangeEnd = 2814697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AreActionsExecuting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static QuantumConsole()
	{
		Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr = IL2CPP.GetIl2CppClass("QFSW.QC.dll", "QFSW.QC", "QuantumConsole");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr);
		NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "<Instance>k__BackingField");
		NativeFieldInfoPtr__canvasScaler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_canvasScaler");
		NativeFieldInfoPtr__containerRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_containerRect");
		NativeFieldInfoPtr__scrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_scrollRect");
		NativeFieldInfoPtr__suggestionPopupTopRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_suggestionPopupTopRect");
		NativeFieldInfoPtr__suggestionPopupBttmRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_suggestionPopupBttmRect");
		NativeFieldInfoPtr__jobCounterRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_jobCounterRect");
		NativeFieldInfoPtr__panels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_panels");
		NativeFieldInfoPtr__theme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_theme");
		NativeFieldInfoPtr__keyConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_keyConfig");
		NativeFieldInfoPtr__localization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_localization");
		NativeFieldInfoPtr_OnSendToServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "OnSendToServer");
		NativeFieldInfoPtr_OnSendToClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "OnSendToClient");
		NativeFieldInfoPtr__lastCommandIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_lastCommandIndex");
		NativeFieldInfoPtr__commandQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_commandQueue");
		NativeFieldInfoPtr__currentCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_currentCommand");
		NativeFieldInfoPtr_ClientCommandPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "ClientCommandPrefix");
		NativeFieldInfoPtr__commandHistoryFilePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_commandHistoryFilePath");
		NativeFieldInfoPtr_InputFieldBlockingFieldName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "InputFieldBlockingFieldName");
		NativeFieldInfoPtr__HasMouseOver_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "<HasMouseOver>k__BackingField");
		NativeFieldInfoPtr_LockScroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "LockScroll");
		NativeFieldInfoPtr_AutoComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "AutoComplete");
		NativeFieldInfoPtr_openConsoleOnMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "openConsoleOnMessage");
		NativeFieldInfoPtr__currentCommandResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_currentCommandResult");
		NativeFieldInfoPtr__lastStartingCommandHistoryProcessTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_lastStartingCommandHistoryProcessTime");
		NativeFieldInfoPtr__lastProcessCommandHistoryTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_lastProcessCommandHistoryTime");
		NativeFieldInfoPtr__isProcessingCommandHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_isProcessingCommandHistory");
		NativeFieldInfoPtr__startingTimeForContinuouslyProcessingCommandHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_startingTimeForContinuouslyProcessingCommandHistory");
		NativeFieldInfoPtr__minTimeBeforeProcessingCommandHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_minTimeBeforeProcessingCommandHistory");
		NativeFieldInfoPtr_m_specialPasteHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "m_specialPasteHandler");
		NativeFieldInfoPtr__IsHistoryInitialized_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "<IsHistoryInitialized>k__BackingField");
		NativeFieldInfoPtr__hyperlinksRegex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_hyperlinksRegex");
		NativeFieldInfoPtr_linkHashes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "linkHashes");
		NativeFieldInfoPtr__enableChainedCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_enableChainedCommands");
		NativeFieldInfoPtr__saveHistoryToCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_saveHistoryToCache");
		NativeFieldInfoPtr__maxSavedHistorySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_maxSavedHistorySize");
		NativeFieldInfoPtr__verboseErrors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_verboseErrors");
		NativeFieldInfoPtr__verboseLogging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_verboseLogging");
		NativeFieldInfoPtr__loggingLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_loggingLevel");
		NativeFieldInfoPtr__openOnLogLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_openOnLogLevel");
		NativeFieldInfoPtr__interceptDebugLogger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_interceptDebugLogger");
		NativeFieldInfoPtr__interceptWhilstInactive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_interceptWhilstInactive");
		NativeFieldInfoPtr__prependTimestamps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_prependTimestamps");
		NativeFieldInfoPtr__supportedState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_supportedState");
		NativeFieldInfoPtr__activateOnStartup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_activateOnStartup");
		NativeFieldInfoPtr__initialiseOnStartup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_initialiseOnStartup");
		NativeFieldInfoPtr__closeOnSubmit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_closeOnSubmit");
		NativeFieldInfoPtr__singletonMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_singletonMode");
		NativeFieldInfoPtr__autoScroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_autoScroll");
		NativeFieldInfoPtr__enableAutocomplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_enableAutocomplete");
		NativeFieldInfoPtr__showPopupDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_showPopupDisplay");
		NativeFieldInfoPtr__suggestionDisplayOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_suggestionDisplayOrder");
		NativeFieldInfoPtr__maxSuggestionDisplaySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_maxSuggestionDisplaySize");
		NativeFieldInfoPtr__useFuzzySearch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_useFuzzySearch");
		NativeFieldInfoPtr__caseSensitiveSearch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_caseSensitiveSearch");
		NativeFieldInfoPtr__collapseSuggestionOverloads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_collapseSuggestionOverloads");
		NativeFieldInfoPtr__showCurrentJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_showCurrentJobs");
		NativeFieldInfoPtr__blockOnAsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_blockOnAsync");
		NativeFieldInfoPtr__storeCommandHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_storeCommandHistory");
		NativeFieldInfoPtr__storeDuplicateCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_storeDuplicateCommands");
		NativeFieldInfoPtr__storeAdjacentDuplicateCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_storeAdjacentDuplicateCommands");
		NativeFieldInfoPtr__commandHistorySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_commandHistorySize");
		NativeFieldInfoPtr__maxStoredLogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_maxStoredLogs");
		NativeFieldInfoPtr__maxLogSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_maxLogSize");
		NativeFieldInfoPtr__showInitLogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_showInitLogs");
		NativeFieldInfoPtr__consoleInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_consoleInput");
		NativeFieldInfoPtr__inputPlaceholderText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_inputPlaceholderText");
		NativeFieldInfoPtr__consoleLogText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_consoleLogText");
		NativeFieldInfoPtr__consoleSuggestionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_consoleSuggestionText");
		NativeFieldInfoPtr__suggestionPopupTopText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_suggestionPopupTopText");
		NativeFieldInfoPtr__suggestionPopupBttmText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_suggestionPopupBttmText");
		NativeFieldInfoPtr__jobCounterText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_jobCounterText");
		NativeFieldInfoPtr__serverName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_serverName");
		NativeFieldInfoPtr_OnStateChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "OnStateChange");
		NativeFieldInfoPtr_OnInvoke = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "OnInvoke");
		NativeFieldInfoPtr_OnClear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "OnClear");
		NativeFieldInfoPtr_OnLog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "OnLog");
		NativeFieldInfoPtr_OnActivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "OnActivate");
		NativeFieldInfoPtr_OnDeactivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "OnDeactivate");
		NativeFieldInfoPtr_OnSuggestionSetGenerated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "OnSuggestionSetGenerated");
		NativeFieldInfoPtr__serializer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_serializer");
		NativeFieldInfoPtr__suggestionStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_suggestionStack");
		NativeFieldInfoPtr__logStorage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_logStorage");
		NativeFieldInfoPtr__logQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_logQueue");
		NativeFieldInfoPtr__IsActive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "<IsActive>k__BackingField");
		NativeFieldInfoPtr__previousCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_previousCommands");
		NativeFieldInfoPtr__currentTasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_currentTasks");
		NativeFieldInfoPtr__currentActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_currentActions");
		NativeFieldInfoPtr__stringBuilderPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_stringBuilderPool");
		NativeFieldInfoPtr__selectedPreviousCommandIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_selectedPreviousCommandIndex");
		NativeFieldInfoPtr__currentInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_currentInput");
		NativeFieldInfoPtr__previousInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_previousInput");
		NativeFieldInfoPtr__isGeneratingTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_isGeneratingTable");
		NativeFieldInfoPtr__consoleRequiresFlush = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_consoleRequiresFlush");
		NativeFieldInfoPtr__textComponents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_textComponents");
		NativeFieldInfoPtr__voidTaskType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, "_voidTaskType");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_QuantumConsole_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663532);
		NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_QuantumConsole_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663533);
		NativeMethodInfoPtr_get_Theme_Public_get_QuantumTheme_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663534);
		NativeMethodInfoPtr_add_OnSendToServer_Private_Static_add_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663535);
		NativeMethodInfoPtr_remove_OnSendToServer_Private_Static_rem_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663536);
		NativeMethodInfoPtr_add_OnSendToClient_Public_Static_add_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663537);
		NativeMethodInfoPtr_remove_OnSendToClient_Public_Static_rem_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663538);
		NativeMethodInfoPtr_get_KeyConfig_Public_get_QuantumKeyConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663539);
		NativeMethodInfoPtr_set_KeyConfig_Public_set_Void_QuantumKeyConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663540);
		NativeMethodInfoPtr_get_Localization_Public_get_QuantumLocalization_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663541);
		NativeMethodInfoPtr_set_Localization_Public_set_Void_QuantumLocalization_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663542);
		NativeMethodInfoPtr_AddSendToServerCallback_Public_Static_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663543);
		NativeMethodInfoPtr_RemoveSendToServerCallback_Public_Static_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663544);
		NativeMethodInfoPtr_AddSendToClientCallback_Public_Static_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663545);
		NativeMethodInfoPtr_RemoveSendToClientCallback_Public_Static_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663546);
		NativeMethodInfoPtr_ReceiveFromServer_Public_Void_CommandResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663547);
		NativeMethodInfoPtr_get_HasMouseOver_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663548);
		NativeMethodInfoPtr_set_HasMouseOver_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663549);
		NativeMethodInfoPtr_get__isResult_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663550);
		NativeMethodInfoPtr_get_IsHistoryInitialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663551);
		NativeMethodInfoPtr_set_IsHistoryInitialized_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663552);
		NativeMethodInfoPtr_get_logFilePath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663553);
		NativeMethodInfoPtr_OnPointerEnter_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663554);
		NativeMethodInfoPtr_OnPointerExit_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663555);
		NativeMethodInfoPtr_UpdateCommands_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663556);
		NativeMethodInfoPtr_get_MaxStoredLogs_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663557);
		NativeMethodInfoPtr_set_MaxStoredLogs_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663558);
		NativeMethodInfoPtr_add_OnStateChange_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663559);
		NativeMethodInfoPtr_remove_OnStateChange_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663560);
		NativeMethodInfoPtr_add_OnInvoke_Public_add_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663561);
		NativeMethodInfoPtr_remove_OnInvoke_Public_rem_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663562);
		NativeMethodInfoPtr_add_OnClear_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663563);
		NativeMethodInfoPtr_remove_OnClear_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663564);
		NativeMethodInfoPtr_add_OnLog_Public_add_Void_Action_1_ILog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663565);
		NativeMethodInfoPtr_remove_OnLog_Public_rem_Void_Action_1_ILog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663566);
		NativeMethodInfoPtr_add_OnActivate_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663567);
		NativeMethodInfoPtr_remove_OnActivate_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663568);
		NativeMethodInfoPtr_add_OnDeactivate_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663569);
		NativeMethodInfoPtr_remove_OnDeactivate_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663570);
		NativeMethodInfoPtr_add_OnSuggestionSetGenerated_Public_add_Void_Action_1_SuggestionSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663571);
		NativeMethodInfoPtr_remove_OnSuggestionSetGenerated_Public_rem_Void_Action_1_SuggestionSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663572);
		NativeMethodInfoPtr_get_IsBlockedByCommands_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663573);
		NativeMethodInfoPtr_get_IsBlockedByAsync_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663574);
		NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663575);
		NativeMethodInfoPtr_set_IsActive_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663576);
		NativeMethodInfoPtr_get_IsFocused_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663577);
		NativeMethodInfoPtr_get_AreActionsExecuting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663578);
		NativeMethodInfoPtr_ApplyTheme_Public_Void_QuantumTheme_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663579);
		NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663580);
		NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663581);
		NativeMethodInfoPtr_GetTableGenerationText_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663582);
		NativeMethodInfoPtr_ProcessCommandHistory_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663583);
		NativeMethodInfoPtr_UpdateSuggestions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663584);
		NativeMethodInfoPtr_ProcessAutocomplete_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663585);
		NativeMethodInfoPtr_FormatSuggestion_Private_Void_IQcSuggestion_Boolean_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663586);
		NativeMethodInfoPtr_GetFormattedSuggestions_Private_String_SuggestionSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663587);
		NativeMethodInfoPtr_GetFormattedSuggestions_Private_Void_SuggestionSet_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663588);
		NativeMethodInfoPtr_UpdatePopupDisplay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663589);
		NativeMethodInfoPtr_SetSuggestion_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663590);
		NativeMethodInfoPtr_UpdateSuggestionText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663591);
		NativeMethodInfoPtr_OverrideConsoleInput_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663592);
		NativeMethodInfoPtr_FocusConsoleInput_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663593);
		NativeMethodInfoPtr_OnInputChange_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663594);
		NativeMethodInfoPtr_ClearHistoricalSuggestions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663595);
		NativeMethodInfoPtr_ClearSuggestions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663596);
		NativeMethodInfoPtr_ClearPopup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663597);
		NativeMethodInfoPtr_InvokeCommand_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663598);
		NativeMethodInfoPtr_ProcessCommandInput_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663599);
		NativeMethodInfoPtr_ProcessCommandInput_Public_Void_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663600);
		NativeMethodInfoPtr_ConsumeResult_Private_CommandResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663601);
		NativeMethodInfoPtr_GenerateCommandLog_Protected_ILog_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663602);
		NativeMethodInfoPtr_HandleCommandResult_Private_Void_CommandResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663603);
		NativeMethodInfoPtr_HandleNextCommand_Public_Void_CommandResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663604);
		NativeMethodInfoPtr_ClearChainedCommands_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663605);
		NativeMethodInfoPtr_ProcessCommands_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663606);
		NativeMethodInfoPtr_InvokeCommand_Public_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663607);
		NativeMethodInfoPtr_SendToClient_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663608);
		NativeMethodInfoPtr_InvokeExternalCommandsAsync_Public_Task_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663609);
		NativeMethodInfoPtr_InvokeCommandsAsync_Public_Task_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663610);
		NativeMethodInfoPtr_GetErrorMessage_Private_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663611);
		NativeMethodInfoPtr_GetInvocationErrorMessage_Private_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663612);
		NativeMethodInfoPtr_GetErrorMessage_Private_String_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663613);
		NativeMethodInfoPtr_LogToConsoleAsync_Public_Void_String_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663614);
		NativeMethodInfoPtr_LogToConsoleAsync_Public_Void_ILog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663615);
		NativeMethodInfoPtr_FlushQueuedLogs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663616);
		NativeMethodInfoPtr_ProcessAsyncTasks_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663617);
		NativeMethodInfoPtr_StartAction_Public_Void_IEnumerator_1_ICommandAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663618);
		NativeMethodInfoPtr_CancelAllActions_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663619);
		NativeMethodInfoPtr_ProcessActions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663620);
		NativeMethodInfoPtr_HandleAsyncJobCounter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663621);
		NativeMethodInfoPtr_Serialize_Public_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663622);
		NativeMethodInfoPtr_LogToConsole_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663623);
		NativeMethodInfoPtr_ParseHyperlinksFromLog_Private_ILog_ILog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663624);
		NativeMethodInfoPtr_UnescapeHTMLCharacters_Private_ILog_ILog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663625);
		NativeMethodInfoPtr_ParseHTMLBulletLists_Private_ILog_ILog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663626);
		NativeMethodInfoPtr_ReplaceLink_Private_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663627);
		NativeMethodInfoPtr_LogToConsole_Public_Void_ILog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663628);
		NativeMethodInfoPtr_FlushToConsoleText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663629);
		NativeMethodInfoPtr_HandleIndexOutOfRangeExceptionDuringFlush_Private_Void_IndexOutOfRangeException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663630);
		NativeMethodInfoPtr_TruncateLog_Private_ILog_ILog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663631);
		NativeMethodInfoPtr_AppendLog_Protected_Void_ILog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663632);
		NativeMethodInfoPtr_RequireFlush_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663633);
		NativeMethodInfoPtr_RemoveLogTrace_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663634);
		NativeMethodInfoPtr_GetScrollBarValue_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663635);
		NativeMethodInfoPtr_ScrollConsoleTo_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663636);
		NativeMethodInfoPtr_ForceConsoleTextUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663637);
		NativeMethodInfoPtr_CheckScrollBarVisibilityNeeded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663638);
		NativeMethodInfoPtr_ScrollConsoleToLatest_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663639);
		NativeMethodInfoPtr_StoreCommand_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663640);
		NativeMethodInfoPtr_ClearConsole_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663641);
		NativeMethodInfoPtr_GetConsoleText_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663642);
		NativeMethodInfoPtr_ClearBuffers_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663643);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663644);
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663645);
		NativeMethodInfoPtr_IsSupportedState_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663646);
		NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663647);
		NativeMethodInfoPtr_DisableQC_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663648);
		NativeMethodInfoPtr_Initialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663649);
		NativeMethodInfoPtr_InitializeCommandHistory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663650);
		NativeMethodInfoPtr_InitializeSuggestionStack_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663651);
		NativeMethodInfoPtr_InitializeLogging_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663652);
		NativeMethodInfoPtr_SetServerName_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663653);
		NativeMethodInfoPtr_CreateLogStorage_Protected_Virtual_New_ILogStorage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663654);
		NativeMethodInfoPtr_CreateLogQueue_Protected_Virtual_New_ILogQueue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663655);
		NativeMethodInfoPtr_CreateSuggestionStack_Protected_Virtual_New_SuggestionStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663656);
		NativeMethodInfoPtr_Toggle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663657);
		NativeMethodInfoPtr_Activate_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663658);
		NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663659);
		NativeMethodInfoPtr_Deactivate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663660);
		NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663661);
		NativeMethodInfoPtr_DebugIntercept_Private_Void_String_String_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663662);
		NativeMethodInfoPtr_ConstructDebugLog_Protected_Virtual_New_ILog_String_String_LogType_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663663);
		NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663664);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663665);
		NativeMethodInfoPtr__ParseHyperlinksFromLog_b__202_0_Private_String_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663667);
		NativeMethodInfoPtr_Method_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr, 100663668);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814462, XrefRangeEnd = 2814475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnSendToServer(Il2CppSystem.Action<string> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_OnSendToServer_Private_Static_add_Void_Action_1_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814475, XrefRangeEnd = 2814488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnSendToServer(Il2CppSystem.Action<string> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_OnSendToServer_Private_Static_rem_Void_Action_1_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814488, XrefRangeEnd = 2814501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnSendToClient(Il2CppSystem.Action<string> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_OnSendToClient_Public_Static_add_Void_Action_1_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814501, XrefRangeEnd = 2814514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnSendToClient(Il2CppSystem.Action<string> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_OnSendToClient_Public_Static_rem_Void_Action_1_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2814530, RefRangeEnd = 2814531, XrefRangeStart = 2814514, XrefRangeEnd = 2814530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddSendToServerCallback(Il2CppSystem.Action<string> callback)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSendToServerCallback_Public_Static_Void_Action_1_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2814547, RefRangeEnd = 2814548, XrefRangeStart = 2814531, XrefRangeEnd = 2814547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveSendToServerCallback(Il2CppSystem.Action<string> callback)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveSendToServerCallback_Public_Static_Void_Action_1_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2814564, RefRangeEnd = 2814565, XrefRangeStart = 2814548, XrefRangeEnd = 2814564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddSendToClientCallback(Il2CppSystem.Action<string> callback)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSendToClientCallback_Public_Static_Void_Action_1_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2814581, RefRangeEnd = 2814582, XrefRangeStart = 2814565, XrefRangeEnd = 2814581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveSendToClientCallback(Il2CppSystem.Action<string> callback)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveSendToClientCallback_Public_Static_Void_Action_1_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void ReceiveFromServer(CommandResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReceiveFromServer_Public_Void_CommandResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814594, XrefRangeEnd = 2814602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnPointerEnter()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnPointerEnter_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 2814610, RefRangeEnd = 2814612, XrefRangeStart = 2814602, XrefRangeEnd = 2814610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnPointerExit()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnPointerExit_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814612, XrefRangeEnd = 2814619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateCommands()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateCommands_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814625, XrefRangeEnd = 2814629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnStateChange(Il2CppSystem.Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_OnStateChange_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814629, XrefRangeEnd = 2814633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnStateChange(Il2CppSystem.Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_OnStateChange_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814633, XrefRangeEnd = 2814638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnInvoke(Il2CppSystem.Action<string> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_OnInvoke_Public_add_Void_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814638, XrefRangeEnd = 2814643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnInvoke(Il2CppSystem.Action<string> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_OnInvoke_Public_rem_Void_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814643, XrefRangeEnd = 2814647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnClear(Il2CppSystem.Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_OnClear_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814647, XrefRangeEnd = 2814651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnClear(Il2CppSystem.Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_OnClear_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814651, XrefRangeEnd = 2814656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnLog(Il2CppSystem.Action<ILog> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_OnLog_Public_add_Void_Action_1_ILog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814656, XrefRangeEnd = 2814661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnLog(Il2CppSystem.Action<ILog> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_OnLog_Public_rem_Void_Action_1_ILog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814661, XrefRangeEnd = 2814665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnActivate(Il2CppSystem.Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_OnActivate_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814665, XrefRangeEnd = 2814669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnActivate(Il2CppSystem.Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_OnActivate_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814669, XrefRangeEnd = 2814673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnDeactivate(Il2CppSystem.Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_OnDeactivate_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814673, XrefRangeEnd = 2814677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnDeactivate(Il2CppSystem.Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_OnDeactivate_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814677, XrefRangeEnd = 2814682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnSuggestionSetGenerated(Il2CppSystem.Action<SuggestionSet> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_OnSuggestionSetGenerated_Public_add_Void_Action_1_SuggestionSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814682, XrefRangeEnd = 2814687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnSuggestionSetGenerated(Il2CppSystem.Action<SuggestionSet> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_OnSuggestionSetGenerated_Public_rem_Void_Action_1_SuggestionSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2814710, RefRangeEnd = 2814711, XrefRangeStart = 2814697, XrefRangeEnd = 2814710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyTheme(QuantumTheme theme, bool forceRefresh = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)theme);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceRefresh;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyTheme_Public_Void_QuantumTheme_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814711, XrefRangeEnd = 2814732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814732, XrefRangeEnd = 2814734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814734, XrefRangeEnd = 2814761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetTableGenerationText()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTableGenerationText_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814761, XrefRangeEnd = 2814776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessCommandHistory()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessCommandHistory_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814776, XrefRangeEnd = 2814784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateSuggestions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateSuggestions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814784, XrefRangeEnd = 2814801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessAutocomplete()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessAutocomplete_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2814815, RefRangeEnd = 2814816, XrefRangeStart = 2814801, XrefRangeEnd = 2814815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FormatSuggestion(IQcSuggestion suggestion, bool selected, StringBuilder buffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)suggestion);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &selected;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatSuggestion_Private_Void_IQcSuggestion_Boolean_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814816, XrefRangeEnd = 2814824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetFormattedSuggestions(SuggestionSet suggestionSet)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)suggestionSet);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFormattedSuggestions_Private_String_SuggestionSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 2814853, RefRangeEnd = 2814855, XrefRangeStart = 2814824, XrefRangeEnd = 2814853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetFormattedSuggestions(SuggestionSet suggestionSet, StringBuilder buffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)suggestionSet);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFormattedSuggestions_Private_Void_SuggestionSet_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 2814896, RefRangeEnd = 2814898, XrefRangeStart = 2814855, XrefRangeEnd = 2814896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdatePopupDisplay()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdatePopupDisplay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 2814928, RefRangeEnd = 2814930, XrefRangeStart = 2814898, XrefRangeEnd = 2814928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSuggestion(int suggestionIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&suggestionIndex);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSuggestion_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 2814949, RefRangeEnd = 2814952, XrefRangeStart = 2814930, XrefRangeEnd = 2814949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateSuggestionText()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateSuggestionText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 2814965, RefRangeEnd = 2814973, XrefRangeStart = 2814952, XrefRangeEnd = 2814965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OverrideConsoleInput(string newInput, bool shouldFocus = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(newInput);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &shouldFocus;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OverrideConsoleInput_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 2814978, RefRangeEnd = 2814983, XrefRangeStart = 2814973, XrefRangeEnd = 2814978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FocusConsoleInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FocusConsoleInput_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2814997, RefRangeEnd = 2814998, XrefRangeStart = 2814983, XrefRangeEnd = 2814997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInputChange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnInputChange_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void ClearHistoricalSuggestions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearHistoricalSuggestions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2814998, XrefRangeEnd = 2815001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearSuggestions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearSuggestions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2815020, RefRangeEnd = 2815021, XrefRangeStart = 2815001, XrefRangeEnd = 2815020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearPopup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearPopup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2815021, XrefRangeEnd = 2815032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InvokeCommand()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeCommand_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2815032, XrefRangeEnd = 2815038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessCommandInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessCommandInput_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2815044, RefRangeEnd = 2815045, XrefRangeStart = 2815038, XrefRangeEnd = 2815044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessCommandInput(string rawCommandInput, bool saveToHistory = true, bool processSilently = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(rawCommandInput);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &saveToHistory;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &processSilently;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessCommandInput_Public_Void_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe CommandResult ConsumeResult()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConsumeResult_Private_CommandResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CommandResult>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 2815071, RefRangeEnd = 2815073, XrefRangeStart = 2815045, XrefRangeEnd = 2815071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ILog GenerateCommandLog(string command)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(command);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateCommandLog_Protected_ILog_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ILog>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2815073, XrefRangeEnd = 2815081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleCommandResult(CommandResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleCommandResult_Private_Void_CommandResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 2815096, RefRangeEnd = 2815100, XrefRangeStart = 2815081, XrefRangeEnd = 2815096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleNextCommand(CommandResult previousResult = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)previousResult);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleNextCommand_Public_Void_CommandResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2815100, XrefRangeEnd = 2815103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearChainedCommands()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearChainedCommands_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 2815130, RefRangeEnd = 2815133, XrefRangeStart = 2815103, XrefRangeEnd = 2815130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessCommands(string commandInput, bool processSilently = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(commandInput);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &processSilently;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessCommands_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 2815168, RefRangeEnd = 2815170, XrefRangeStart = 2815133, XrefRangeEnd = 2815168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object InvokeCommand(string command)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(command);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeCommand_Public_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2815174, RefRangeEnd = 2815175, XrefRangeStart = 2815170, XrefRangeEnd = 2815174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendToClient(string command)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(command);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendToClient_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2815175, XrefRangeEnd = 2815183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Task InvokeExternalCommandsAsync(string filePath)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeExternalCommandsAsync_Public_Task_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2815183, XrefRangeEnd = 2815191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Task InvokeCommandsAsync(IEnumerable<string> commands)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)commands);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeCommandsAsync_Public_Task_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2815191, XrefRangeEnd = 2815193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetErrorMessage(Il2CppSystem.Exception e)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)e);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetErrorMessage_Private_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2815193, XrefRangeEnd = 2815195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetInvocationErrorMessage(Il2CppSystem.Exception e)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)e);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInvocationErrorMessage_Private_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 2815218, RefRangeEnd = 2815222, XrefRangeStart = 2815195, XrefRangeEnd = 2815218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetErrorMessage(Il2CppSystem.Exception e, string label)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)e);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(label);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetErrorMessage_Private_String_Exception_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2815222, XrefRangeEnd = 2815231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LogToConsoleAsync(string logText, LogType logType = LogType.Log)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(logText);
		*(LogType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &logType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogToConsoleAsync_Public_Void_String_LogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 2815235, RefRangeEnd = 2815237, XrefRangeStart = 2815231, XrefRangeEnd = 2815235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LogToConsoleAsync(ILog log)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)log);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogToConsoleAsync_Public_Void_ILog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 2815276, RefRangeEnd = 2815278, XrefRangeStart = 2815237, XrefRangeEnd = 2815276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FlushQueuedLogs()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FlushQueuedLogs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 2815334, RefRangeEnd = 2815337, XrefRangeStart = 2815278, XrefRangeEnd = 2815334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessAsyncTasks()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessAsyncTasks_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 2815342, RefRangeEnd = 2815344, XrefRangeStart = 2815337, XrefRangeEnd = 2815342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartAction(IEnumerator<ICommandAction> action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartAction_Public_Void_IEnumerator_1_ICommandAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2815344, XrefRangeEnd = 2815347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CancelAllActions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CancelAllActions_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 2815355, RefRangeEnd = 2815357, XrefRangeStart = 2815347, XrefRangeEnd = 2815355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessActions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessActions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2815376, RefRangeEnd = 2815377, XrefRangeStart = 2815357, XrefRangeEnd = 2815376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleAsyncJobCounter()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleAsyncJobCounter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 2815379, RefRangeEnd = 2815381, XrefRangeStart = 2815377, XrefRangeEnd = 2815379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string Serialize(Il2CppSystem.Object value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Serialize_Public_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 2815398, RefRangeEnd = 2815411, XrefRangeStart = 2815381, XrefRangeEnd = 2815398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LogToConsole(string logText, bool newLine = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(logText);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newLine;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogToConsole_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2815411, XrefRangeEnd = 2815429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ILog ParseHyperlinksFromLog(ILog log)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)log);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseHyperlinksFromLog_Private_ILog_ILog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ILog>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2815429, XrefRangeEnd = 2815439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ILog UnescapeHTMLCharacters(ILog log)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)log);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnescapeHTMLCharacters_Private_ILog_ILog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ILog>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2815439, XrefRangeEnd = 2815469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ILog ParseHTMLBulletLists(ILog log)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)log);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseHTMLBulletLists_Private_ILog_ILog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ILog>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2815508, RefRangeEnd = 2815509, XrefRangeStart = 2815469, XrefRangeEnd = 2815508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string ReplaceLink(string text, string href)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(href);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReplaceLink_Private_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 2815574, RefRangeEnd = 2815577, XrefRangeStart = 2815509, XrefRangeEnd = 2815574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LogToConsole(ILog log)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)log);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogToConsole_Public_Void_ILog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2815588, RefRangeEnd = 2815589, XrefRangeStart = 2815577, XrefRangeEnd = 2815588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FlushToConsoleText()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FlushToConsoleText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2815608, RefRangeEnd = 2815609, XrefRangeStart = 2815589, XrefRangeEnd = 2815608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleIndexOutOfRangeExceptionDuringFlush(Il2CppSystem.IndexOutOfRangeException exception)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)exception);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleIndexOutOfRangeExceptionDuringFlush_Private_Void_IndexOutOfRangeException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2815615, RefRangeEnd = 2815616, XrefRangeStart = 2815609, XrefRangeEnd = 2815615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ILog TruncateLog(ILog log)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)log);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TruncateLog_Private_ILog_ILog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ILog>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2815620, RefRangeEnd = 2815621, XrefRangeStart = 2815616, XrefRangeEnd = 2815620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AppendLog(ILog log)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)log);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AppendLog_Protected_Void_ILog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void RequireFlush()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RequireFlush_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2815624, RefRangeEnd = 2815625, XrefRangeStart = 2815621, XrefRangeEnd = 2815624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveLogTrace()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveLogTrace_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2815627, RefRangeEnd = 2815628, XrefRangeStart = 2815625, XrefRangeEnd = 2815627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetScrollBarValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetScrollBarValue_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2815633, RefRangeEnd = 2815634, XrefRangeStart = 2815628, XrefRangeEnd = 2815633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ScrollConsoleTo(float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScrollConsoleTo_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2815636, RefRangeEnd = 2815637, XrefRangeStart = 2815634, XrefRangeEnd = 2815636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ForceConsoleTextUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForceConsoleTextUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2815637, XrefRangeEnd = 2815640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckScrollBarVisibilityNeeded()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckScrollBarVisibilityNeeded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 2815645, RefRangeEnd = 2815648, XrefRangeStart = 2815640, XrefRangeEnd = 2815645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ScrollConsoleToLatest()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScrollConsoleToLatest_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 2815662, RefRangeEnd = 2815666, XrefRangeStart = 2815648, XrefRangeEnd = 2815662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StoreCommand(string command)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(command);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StoreCommand_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2815666, XrefRangeEnd = 2815674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearConsole()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearConsole_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe string GetConsoleText()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetConsoleText_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2815674, XrefRangeEnd = 2815678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void ClearBuffers()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ClearBuffers_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2815678, XrefRangeEnd = 2815733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool IsSupportedState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSupportedState_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2815733, XrefRangeEnd = 2815751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2815751, XrefRangeEnd = 2815755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisableQC()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableQC_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 2815793, RefRangeEnd = 2815799, XrefRangeStart = 2815755, XrefRangeEnd = 2815793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 2815825, RefRangeEnd = 2815827, XrefRangeStart = 2815799, XrefRangeEnd = 2815825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeCommandHistory()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeCommandHistory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2815827, XrefRangeEnd = 2815832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeSuggestionStack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeSuggestionStack_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void InitializeLogging()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeLogging_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2815833, RefRangeEnd = 2815834, XrefRangeStart = 2815832, XrefRangeEnd = 2815833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetServerName(string serverName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(serverName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetServerName_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2815834, XrefRangeEnd = 2815838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual ILogStorage CreateLogStorage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreateLogStorage_Protected_Virtual_New_ILogStorage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ILogStorage>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2815838, XrefRangeEnd = 2815848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual ILogQueue CreateLogQueue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreateLogQueue_Protected_Virtual_New_ILogQueue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ILogQueue>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2815848, XrefRangeEnd = 2815852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual SuggestionStack CreateSuggestionStack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreateSuggestionStack_Protected_Virtual_New_SuggestionStack_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SuggestionStack>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 2815856, RefRangeEnd = 2815860, XrefRangeStart = 2815852, XrefRangeEnd = 2815856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Toggle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Toggle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 2815864, RefRangeEnd = 2815866, XrefRangeStart = 2815860, XrefRangeEnd = 2815864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Activate(bool shouldFocus = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&shouldFocus);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Activate_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2815866, XrefRangeEnd = 2815881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnApplicationQuit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 2815883, RefRangeEnd = 2815885, XrefRangeStart = 2815881, XrefRangeEnd = 2815883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Deactivate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deactivate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2815888, RefRangeEnd = 2815889, XrefRangeStart = 2815885, XrefRangeEnd = 2815888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2815889, XrefRangeEnd = 2815892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DebugIntercept(string condition, string stackTrace, LogType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(condition);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(stackTrace);
		*(LogType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DebugIntercept_Private_Void_String_String_LogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2815892, XrefRangeEnd = 2815931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual ILog ConstructDebugLog(string condition, string stackTrace, LogType type, bool prependTimeStamp, bool appendStackTrace)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(condition);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(stackTrace);
		*(LogType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &prependTimeStamp;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &appendStackTrace;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ConstructDebugLog_Protected_Virtual_New_ILog_String_String_LogType_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ILog>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2815931, XrefRangeEnd = 2815937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnValidate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2815937, XrefRangeEnd = 2816002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe QuantumConsole()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuantumConsole>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2816002, XrefRangeEnd = 2816008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string _ParseHyperlinksFromLog_b__202_0(Match match)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)match);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ParseHyperlinksFromLog_b__202_0_Private_String_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2816018, RefRangeEnd = 2816019, XrefRangeStart = 2816008, XrefRangeEnd = 2816018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Method_Private_Boolean_String_0(string command)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(command);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public QuantumConsole(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
