#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <stdint.h>
#include <limits>



// System.Byte
struct Byte_t94D9231AC217BE4D2E004C4CD32DF6D099EA41A3;
// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915;

struct unitytls_errorstate_tC926EE4582920BE2C1DB1F3F65619B810D5AB902;
struct unitytls_key_ref_t6BD91D013DF11047C53738FEEB12CE290FDC71A2;
struct unitytls_tlsctx_tF8BBCBFE1E957B846442DED65ECB89BC5307DEAE;
struct unitytls_x509list_ref_t6C5C1CF0B720516A681CB741104A164FD8B3CF17;
struct unitytls_x509name_t8A1108C917795D8FE946B50769ACE51489C7BF5D;


IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F  : public RuntimeObject
{
};
// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_com
{
};

// System.IntPtr
struct IntPtr_t 
{
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;
};

struct IntPtr_t_StaticFields
{
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;
};

// Realms.Native.TableKey
struct TableKey_tDE0311CA4D5C298F8BB7E0352BAEE9910E60B713 
{
	// System.UInt32 Realms.Native.TableKey::Value
	uint32_t ___Value_0;
};

// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915 
{
	union
	{
		struct
		{
		};
		uint8_t Void_t4861ACF8F4594C3437BB48B6E56783494B843915__padding[1];
	};
};

// Realms.Native.PrimitiveValue/<decimal_bits>e__FixedBuffer
struct U3Cdecimal_bitsU3Ee__FixedBuffer_tF7D50EE072C933FF8FA41523147EAE0AF67B528D 
{
	union
	{
		struct
		{
			// System.UInt64 Realms.Native.PrimitiveValue/<decimal_bits>e__FixedBuffer::FixedElementField
			uint64_t ___FixedElementField_0;
		};
		uint8_t U3Cdecimal_bitsU3Ee__FixedBuffer_tF7D50EE072C933FF8FA41523147EAE0AF67B528D__padding[16];
	};
};

// Realms.Native.PrimitiveValue/<guid_bytes>e__FixedBuffer
struct U3Cguid_bytesU3Ee__FixedBuffer_tC99494C5FB5D0B6DDFDBECE6BB8FEFAEE7165DC3 
{
	union
	{
		struct
		{
			// System.Byte Realms.Native.PrimitiveValue/<guid_bytes>e__FixedBuffer::FixedElementField
			uint8_t ___FixedElementField_0;
		};
		uint8_t U3Cguid_bytesU3Ee__FixedBuffer_tC99494C5FB5D0B6DDFDBECE6BB8FEFAEE7165DC3__padding[16];
	};
};

// Realms.Native.PrimitiveValue/<object_id_bytes>e__FixedBuffer
struct U3Cobject_id_bytesU3Ee__FixedBuffer_t8744739B792C1B30310C858286163338499BA3FB 
{
	union
	{
		struct
		{
			// System.Byte Realms.Native.PrimitiveValue/<object_id_bytes>e__FixedBuffer::FixedElementField
			uint8_t ___FixedElementField_0;
		};
		uint8_t U3Cobject_id_bytesU3Ee__FixedBuffer_t8744739B792C1B30310C858286163338499BA3FB__padding[12];
	};
};

// Realms.Native.PrimitiveValue/TimestampValue
struct TimestampValue_t6D61E9CC604EF7895FE1872840E8227341DD69DC 
{
	// System.Int64 Realms.Native.PrimitiveValue/TimestampValue::seconds
	int64_t ___seconds_3;
	// System.Int32 Realms.Native.PrimitiveValue/TimestampValue::nanoseconds
	int32_t ___nanoseconds_4;
};

// Mono.Unity.UnityTls/unitytls_x509_ref
struct unitytls_x509_ref_t9CEB17766B4144117333AB50379B21A357FA4333 
{
	// System.UInt64 Mono.Unity.UnityTls/unitytls_x509_ref::handle
	uint64_t ___handle_0;
};

// Mono.Unity.UnityTls/unitytls_x509list_ref
struct unitytls_x509list_ref_t6C5C1CF0B720516A681CB741104A164FD8B3CF17 
{
	// System.UInt64 Mono.Unity.UnityTls/unitytls_x509list_ref::handle
	uint64_t ___handle_0;
};

// Realms.NativeException
struct NativeException_tD0D4AE8BF0E1593EA969F3725B458DDA9B8D25A7 
{
	// Realms.Exceptions.RealmExceptionCodes Realms.NativeException::type
	int8_t ___type_0;
	// System.Byte* Realms.NativeException::messageBytes
	uint8_t* ___messageBytes_1;
	// System.IntPtr Realms.NativeException::messageLength
	intptr_t ___messageLength_2;
	// System.IntPtr Realms.NativeException::detail
	intptr_t ___detail_3;
	// System.IntPtr Realms.NativeException::detailLength
	intptr_t ___detailLength_4;
};

// Realms.Native.Schema
struct Schema_t119F81EC190B6E7B0C4776F0D55C0DC834A2E840 
{
	// System.IntPtr Realms.Native.Schema::objects
	intptr_t ___objects_0;
	// System.Int32 Realms.Native.Schema::objects_len
	int32_t ___objects_len_1;
	// System.IntPtr Realms.Native.Schema::properties
	intptr_t ___properties_2;
};

// Realms.Native.PrimitiveValue/BinaryValue
struct BinaryValue_t3E6C3999D1D5656B4E0F1A33202BE7832DD64A5D 
{
	// System.Byte* Realms.Native.PrimitiveValue/BinaryValue::data
	uint8_t* ___data_0;
	// System.IntPtr Realms.Native.PrimitiveValue/BinaryValue::size
	intptr_t ___size_1;
};

// Realms.Native.PrimitiveValue/LinkValue
struct LinkValue_t2E971397736EAD9583513BF15C18315B51B81EA3 
{
	// System.IntPtr Realms.Native.PrimitiveValue/LinkValue::object_ptr
	intptr_t ___object_ptr_0;
	// Realms.Native.TableKey Realms.Native.PrimitiveValue/LinkValue::table_key
	TableKey_tDE0311CA4D5C298F8BB7E0352BAEE9910E60B713 ___table_key_1;
};

// Realms.Native.PrimitiveValue/StringValue
struct StringValue_tB6BEEA6092AA922F23EB7B5F7A7A46FF02462959 
{
	// System.Byte* Realms.Native.PrimitiveValue/StringValue::data
	uint8_t* ___data_0;
	// System.IntPtr Realms.Native.PrimitiveValue/StringValue::size
	intptr_t ___size_1;
};

// Realms.Native.PrimitiveValue
struct PrimitiveValue_t0B0F1BDA24EE2A5C70CE1D6C87EF2C8EE9FAC30B 
{
	union
	{
		#pragma pack(push, tp, 1)
		struct
		{
			// System.Int64 Realms.Native.PrimitiveValue::int_value
			int64_t ___int_value_0;
		};
		#pragma pack(pop, tp)
		struct
		{
			int64_t ___int_value_0_forAlignmentOnly;
		};
		#pragma pack(push, tp, 1)
		struct
		{
			// System.Single Realms.Native.PrimitiveValue::float_value
			float ___float_value_1;
		};
		#pragma pack(pop, tp)
		struct
		{
			float ___float_value_1_forAlignmentOnly;
		};
		#pragma pack(push, tp, 1)
		struct
		{
			// System.Double Realms.Native.PrimitiveValue::double_value
			double ___double_value_2;
		};
		#pragma pack(pop, tp)
		struct
		{
			double ___double_value_2_forAlignmentOnly;
		};
		#pragma pack(push, tp, 1)
		struct
		{
			// Realms.Native.PrimitiveValue/<decimal_bits>e__FixedBuffer Realms.Native.PrimitiveValue::decimal_bits
			U3Cdecimal_bitsU3Ee__FixedBuffer_tF7D50EE072C933FF8FA41523147EAE0AF67B528D ___decimal_bits_3;
		};
		#pragma pack(pop, tp)
		struct
		{
			U3Cdecimal_bitsU3Ee__FixedBuffer_tF7D50EE072C933FF8FA41523147EAE0AF67B528D ___decimal_bits_3_forAlignmentOnly;
		};
		#pragma pack(push, tp, 1)
		struct
		{
			// Realms.Native.PrimitiveValue/<object_id_bytes>e__FixedBuffer Realms.Native.PrimitiveValue::object_id_bytes
			U3Cobject_id_bytesU3Ee__FixedBuffer_t8744739B792C1B30310C858286163338499BA3FB ___object_id_bytes_4;
		};
		#pragma pack(pop, tp)
		struct
		{
			U3Cobject_id_bytesU3Ee__FixedBuffer_t8744739B792C1B30310C858286163338499BA3FB ___object_id_bytes_4_forAlignmentOnly;
		};
		#pragma pack(push, tp, 1)
		struct
		{
			// Realms.Native.PrimitiveValue/<guid_bytes>e__FixedBuffer Realms.Native.PrimitiveValue::guid_bytes
			U3Cguid_bytesU3Ee__FixedBuffer_tC99494C5FB5D0B6DDFDBECE6BB8FEFAEE7165DC3 ___guid_bytes_5;
		};
		#pragma pack(pop, tp)
		struct
		{
			U3Cguid_bytesU3Ee__FixedBuffer_tC99494C5FB5D0B6DDFDBECE6BB8FEFAEE7165DC3 ___guid_bytes_5_forAlignmentOnly;
		};
		#pragma pack(push, tp, 1)
		struct
		{
			char ___dontuse_6_OffsetPadding[8];
			// System.Int64 Realms.Native.PrimitiveValue::dontuse
			int64_t ___dontuse_6;
		};
		#pragma pack(pop, tp)
		struct
		{
			char ___dontuse_6_OffsetPadding_forAlignmentOnly[8];
			int64_t ___dontuse_6_forAlignmentOnly;
		};
		#pragma pack(push, tp, 1)
		struct
		{
			// Realms.Native.PrimitiveValue/StringValue Realms.Native.PrimitiveValue::string_value
			StringValue_tB6BEEA6092AA922F23EB7B5F7A7A46FF02462959 ___string_value_7;
		};
		#pragma pack(pop, tp)
		struct
		{
			StringValue_tB6BEEA6092AA922F23EB7B5F7A7A46FF02462959 ___string_value_7_forAlignmentOnly;
		};
		#pragma pack(push, tp, 1)
		struct
		{
			// Realms.Native.PrimitiveValue/BinaryValue Realms.Native.PrimitiveValue::data_value
			BinaryValue_t3E6C3999D1D5656B4E0F1A33202BE7832DD64A5D ___data_value_8;
		};
		#pragma pack(pop, tp)
		struct
		{
			BinaryValue_t3E6C3999D1D5656B4E0F1A33202BE7832DD64A5D ___data_value_8_forAlignmentOnly;
		};
		#pragma pack(push, tp, 1)
		struct
		{
			// Realms.Native.PrimitiveValue/TimestampValue Realms.Native.PrimitiveValue::timestamp_value
			TimestampValue_t6D61E9CC604EF7895FE1872840E8227341DD69DC ___timestamp_value_9;
		};
		#pragma pack(pop, tp)
		struct
		{
			TimestampValue_t6D61E9CC604EF7895FE1872840E8227341DD69DC ___timestamp_value_9_forAlignmentOnly;
		};
		#pragma pack(push, tp, 1)
		struct
		{
			// Realms.Native.PrimitiveValue/LinkValue Realms.Native.PrimitiveValue::link_value
			LinkValue_t2E971397736EAD9583513BF15C18315B51B81EA3 ___link_value_10;
		};
		#pragma pack(pop, tp)
		struct
		{
			LinkValue_t2E971397736EAD9583513BF15C18315B51B81EA3 ___link_value_10_forAlignmentOnly;
		};
		#pragma pack(push, tp, 1)
		struct
		{
			char ___Type_11_OffsetPadding[16];
			// Realms.RealmValueType Realms.Native.PrimitiveValue::Type
			uint8_t ___Type_11;
		};
		#pragma pack(pop, tp)
		struct
		{
			char ___Type_11_OffsetPadding_forAlignmentOnly[16];
			uint8_t ___Type_11_forAlignmentOnly;
		};
	};
};

// Realms.Sync.Native.AppError
struct AppError_t76E59E2102C582D663A3D26011D7CA63B7759946 
{
	// System.Boolean Realms.Sync.Native.AppError::is_null
	bool ___is_null_0;
	// Realms.Native.PrimitiveValue Realms.Sync.Native.AppError::message
	PrimitiveValue_t0B0F1BDA24EE2A5C70CE1D6C87EF2C8EE9FAC30B ___message_1;
	// Realms.Native.PrimitiveValue Realms.Sync.Native.AppError::error_category
	PrimitiveValue_t0B0F1BDA24EE2A5C70CE1D6C87EF2C8EE9FAC30B ___error_category_2;
	// Realms.Native.PrimitiveValue Realms.Sync.Native.AppError::logs_link
	PrimitiveValue_t0B0F1BDA24EE2A5C70CE1D6C87EF2C8EE9FAC30B ___logs_link_3;
	// System.Int32 Realms.Sync.Native.AppError::http_status_code
	int32_t ___http_status_code_4;
};

// Realms.Sync.Native.Subscription
struct Subscription_t71D228FFF062330388899D9060576B43B033D18E 
{
	// Realms.Native.PrimitiveValue Realms.Sync.Native.Subscription::id
	PrimitiveValue_t0B0F1BDA24EE2A5C70CE1D6C87EF2C8EE9FAC30B ___id_0;
	// Realms.Native.PrimitiveValue Realms.Sync.Native.Subscription::name
	PrimitiveValue_t0B0F1BDA24EE2A5C70CE1D6C87EF2C8EE9FAC30B ___name_1;
	// Realms.Native.PrimitiveValue Realms.Sync.Native.Subscription::object_type
	PrimitiveValue_t0B0F1BDA24EE2A5C70CE1D6C87EF2C8EE9FAC30B ___object_type_2;
	// Realms.Native.PrimitiveValue Realms.Sync.Native.Subscription::query
	PrimitiveValue_t0B0F1BDA24EE2A5C70CE1D6C87EF2C8EE9FAC30B ___query_3;
	// Realms.Native.PrimitiveValue Realms.Sync.Native.Subscription::created_at
	PrimitiveValue_t0B0F1BDA24EE2A5C70CE1D6C87EF2C8EE9FAC30B ___created_at_4;
	// Realms.Native.PrimitiveValue Realms.Sync.Native.Subscription::updated_at
	PrimitiveValue_t0B0F1BDA24EE2A5C70CE1D6C87EF2C8EE9FAC30B ___updated_at_5;
	// System.Boolean Realms.Sync.Native.Subscription::has_value
	bool ___has_value_6;
};

// Realms.Native.HttpClientTransport/HttpClientRequest
struct HttpClientRequest_t078B6032A08DB03EEA44B54E49FE8A25D7DD04B7 
{
	// Realms.Native.HttpClientTransport/NativeHttpMethod Realms.Native.HttpClientTransport/HttpClientRequest::method
	int32_t ___method_0;
	// Realms.Native.PrimitiveValue Realms.Native.HttpClientTransport/HttpClientRequest::url
	PrimitiveValue_t0B0F1BDA24EE2A5C70CE1D6C87EF2C8EE9FAC30B ___url_1;
	// System.UInt64 Realms.Native.HttpClientTransport/HttpClientRequest::timeout_ms
	uint64_t ___timeout_ms_2;
	// System.IntPtr Realms.Native.HttpClientTransport/HttpClientRequest::headers
	intptr_t ___headers_3;
	// System.IntPtr Realms.Native.HttpClientTransport/HttpClientRequest::headers_len
	intptr_t ___headers_len_4;
	// Realms.Native.PrimitiveValue Realms.Native.HttpClientTransport/HttpClientRequest::body
	PrimitiveValue_t0B0F1BDA24EE2A5C70CE1D6C87EF2C8EE9FAC30B ___body_5;
	// System.IntPtr Realms.Native.HttpClientTransport/HttpClientRequest::managed_http_client
	intptr_t ___managed_http_client_6;
};
#ifdef __clang__
#pragma clang diagnostic pop
#endif

extern "C" void CDECL ReversePInvokeWrapper_AppHandle_HandleApiKeysCallback_mFCC2A906DAD8ACFB0078E79012753C3A3174D669(intptr_t ___tcs_ptr0, intptr_t ___api_keys1, intptr_t ___api_keys_len2, AppError_t76E59E2102C582D663A3D26011D7CA63B7759946 ___error3);
extern "C" void CDECL ReversePInvokeWrapper_AppHandle_HandleLogMessage_m732A31DA5D0ECC68662E3CE12730C884BFDE5414(intptr_t ___managedHandler0, PrimitiveValue_t0B0F1BDA24EE2A5C70CE1D6C87EF2C8EE9FAC30B ___messageValue1, int32_t ___level2);
extern "C" void CDECL ReversePInvokeWrapper_AppHandle_HandleStringCallback_mCFC9D3FA0F9FE704C08314103BE39681695F0349(intptr_t ___tcs_ptr0, PrimitiveValue_t0B0F1BDA24EE2A5C70CE1D6C87EF2C8EE9FAC30B ___response1, AppError_t76E59E2102C582D663A3D26011D7CA63B7759946 ___error2);
extern "C" void CDECL ReversePInvokeWrapper_AppHandle_HandleTaskCompletion_m29CBB73CE7AC5655DB9FD83045BE02D40377CCEB(intptr_t ___tcs_ptr0, AppError_t76E59E2102C582D663A3D26011D7CA63B7759946 ___error1);
extern "C" void CDECL ReversePInvokeWrapper_AppHandle_HandleUserCallback_m59195C69F2CDFEFA5BE8947577B7E0F4BB05E049(intptr_t ___tcs_ptr0, intptr_t ___user_ptr1, AppError_t76E59E2102C582D663A3D26011D7CA63B7759946 ___error2);
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_CultureInfo_OnCultureInfoChangedInAppX_m407BCFC1029A4485B7B063BC2F3601968C3BE577(Il2CppChar* ___language0);
extern "C" int32_t CDECL ReversePInvokeWrapper_DeflateStreamNative_UnmanagedRead_m321A2621068F1C9509594A4D8F405F4F12C1CEB3(intptr_t ___buffer0, int32_t ___length1, intptr_t ___data2);
extern "C" int32_t CDECL ReversePInvokeWrapper_DeflateStreamNative_UnmanagedWrite_mB0AD438266A9DD2813715E8BC90BF07DC7A02F52(intptr_t ___buffer0, int32_t ___length1, intptr_t ___data2);
extern "C" void CDECL ReversePInvokeWrapper_DictionaryHandle_NotifyDictionaryChanged_mD43B3CB619C94763E63B30753FDF8018D8F21CC2(intptr_t ___managedHandle0, intptr_t ___changes1);
extern "C" void CDECL ReversePInvokeWrapper_HttpClientTransport_ExecuteRequest_m35290E89DDC84CD81E3946907D4FB5CAE9121205(HttpClientRequest_t078B6032A08DB03EEA44B54E49FE8A25D7DD04B7 ___request0, intptr_t ___callback1);
extern "C" void CDECL ReversePInvokeWrapper_NotifiableObjectHandleBase_NotifyObjectChanged_m66C86BA2E8E810BEA2AD2BACC5F0774B87127FC1(intptr_t ___managedHandle0, intptr_t ___changes1);
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_OSSpecificSynchronizationContext_InvocationEntry_mF93C3CF6DBEC86E377576D840CAF517CB6E4D7E3(intptr_t ___arg0);
extern "C" void CDECL ReversePInvokeWrapper_SessionHandle_HandleSessionError_m3E24836C3BD6C888EBE26CF1005C6FB056C3ED92(intptr_t ___sessionHandlePtr0, int32_t ___errorCode1, PrimitiveValue_t0B0F1BDA24EE2A5C70CE1D6C87EF2C8EE9FAC30B ___message2, intptr_t ___userInfoPairs3, intptr_t ___userInfoPairsLength4, uint8_t ___isClientReset5, intptr_t ___managedSyncConfigurationBaseHandle6);
extern "C" void CDECL ReversePInvokeWrapper_SessionHandle_HandleSessionProgress_m97873A8809EF2B1B24D3F3497843BA0FD714859C(intptr_t ___tokenPtr0, uint64_t ___transferredBytes1, uint64_t ___transferableBytes2);
extern "C" void CDECL ReversePInvokeWrapper_SessionHandle_HandleSessionPropertyChangedCallback_mE8B536808245CDAF0CBBFCDB9062B5F9559E1EC6(intptr_t ___managedSessionHandle0, uint8_t ___property1);
extern "C" void CDECL ReversePInvokeWrapper_SessionHandle_HandleSessionWaitCallback_m11DBC1B9A62F91CBC6263D3B6BB3DC5859E408C7(intptr_t ___taskCompletionSource0, int32_t ___error_code1, PrimitiveValue_t0B0F1BDA24EE2A5C70CE1D6C87EF2C8EE9FAC30B ___message2);
extern "C" int32_t CDECL ReversePInvokeWrapper_SessionHandle_NotifyAfterClientReset_m6B7EFB5A4100182570E56B9983D731296D85D068(intptr_t ___beforeFrozen0, intptr_t ___after1, intptr_t ___managedSyncConfigurationHandle2, int32_t ___didRecover3);
extern "C" int32_t CDECL ReversePInvokeWrapper_SessionHandle_NotifyBeforeClientReset_m2D4BD0DAA88BBBE0D14A702CFA8AB7D70723E4ED(intptr_t ___beforeFrozen0, intptr_t ___managedSyncConfigurationHandle1);
extern "C" void CDECL ReversePInvokeWrapper_SharedRealmHandle_DisposeGCHandleCallback_m668A07D0D17FEE9423E450E4DDC72A767CB10E0A(intptr_t ___handle0);
extern "C" void CDECL ReversePInvokeWrapper_SharedRealmHandle_GetNativeSchema_mF6C796D3BCF7A47B591E1D42669A1E0EBCA15476(Schema_t119F81EC190B6E7B0C4776F0D55C0DC834A2E840 ___schema0, intptr_t ___managedCallbackPtr1);
extern "C" void CDECL ReversePInvokeWrapper_SharedRealmHandle_HandleOpenRealmCallback_m8C357CF44BD0E5FB927D311EA8B04A1E8E19417D(intptr_t ___taskCompletionSource0, intptr_t ___realm_reference1, NativeException_tD0D4AE8BF0E1593EA969F3725B458DDA9B8D25A7 ___ex2);
extern "C" void CDECL ReversePInvokeWrapper_SharedRealmHandle_HandleTaskCompletionCallback_m8EFFD66BC7C8BC06B74728779E9C0C302330B6EB(intptr_t ___tcs_ptr0, uint8_t ___invoke_async1, NativeException_tD0D4AE8BF0E1593EA969F3725B458DDA9B8D25A7 ___ex2);
extern "C" void CDECL ReversePInvokeWrapper_SharedRealmHandle_LogMessage_m853C5563B02C3C419B2255F0205253A0420523C2(PrimitiveValue_t0B0F1BDA24EE2A5C70CE1D6C87EF2C8EE9FAC30B ___message0, int32_t ___level1);
extern "C" void CDECL ReversePInvokeWrapper_SharedRealmHandle_NotifyRealmChanged_m6E4E0156A94C47BAE7E3D16E7B1B53861ED2B1B7(intptr_t ___stateHandle0);
extern "C" intptr_t CDECL ReversePInvokeWrapper_SharedRealmHandle_OnDataInitialization_m0EADE39796EE67E85EACF81BC153FB607483B826(intptr_t ___managedConfigHandle0, intptr_t ___realmPtr1);
extern "C" intptr_t CDECL ReversePInvokeWrapper_SharedRealmHandle_OnMigration_m13ACEC8D538DDCB3AD48A8E6B7E605D376C62355(intptr_t ___oldRealmPtr0, intptr_t ___newRealmPtr1, intptr_t ___migrationSchema2, Schema_t119F81EC190B6E7B0C4776F0D55C0DC834A2E840 ___oldSchema3, uint64_t ___schemaVersion4, intptr_t ___managedConfigHandle5);
extern "C" intptr_t CDECL ReversePInvokeWrapper_SharedRealmHandle_ShouldCompactOnLaunchCallback_m87A2BDFF783115E2B6196050134B074E90525B44(intptr_t ___managedConfigHandle0, uint64_t ___totalSize1, uint64_t ___dataSize2, uint8_t* ___shouldCompact3);
extern "C" void CDECL ReversePInvokeWrapper_SubscriptionSetHandle_HandleStateWaitCallback_mDE2E1712818EC4DDBEA971216031FBC17D480487(intptr_t ___taskCompletionSource0, uint8_t ___state1, PrimitiveValue_t0B0F1BDA24EE2A5C70CE1D6C87EF2C8EE9FAC30B ___message2);
extern "C" void CDECL ReversePInvokeWrapper_SubscriptionSetHandle_OnGetSubscription_m7077C72279810E74A35D83BC0F57ED0057CAF550(intptr_t ___managedCallbackPtr0, Subscription_t71D228FFF062330388899D9060576B43B033D18E ___subscription1);
extern "C" intptr_t CDECL ReversePInvokeWrapper_SynchronizationContextScheduler_GetCurrentSynchronizationContext_m0E56528172407B1E8D3EBA8423F9982695B70A5D();
extern "C" uint8_t CDECL ReversePInvokeWrapper_SynchronizationContextScheduler_IsOnSynchronizationContext_m4159E8B18883228BCAC16E4A7C2DDB14C1DB8BD2(intptr_t ___context0, intptr_t ___targetContext1);
extern "C" void CDECL ReversePInvokeWrapper_SynchronizationContextScheduler_PostOnSynchronizationContext_m8164B6735EBD57EEAB505BD93070FDB107F24411(intptr_t ___context0, intptr_t ___user_data1);
extern "C" void CDECL ReversePInvokeWrapper_SynchronizationContextScheduler_ReleaseSynchronizationContext_m52779C54E97B974D691C6C9F560A15CE6C6C4FF6(intptr_t ___context0);
extern "C" void CDECL ReversePInvokeWrapper_UnityTlsContext_CertificateCallback_m8CC672A44A8CCFD2A3EB2D9B38A9A134F6EF706B(void* ___userData0, unitytls_tlsctx_tF8BBCBFE1E957B846442DED65ECB89BC5307DEAE* ___ctx1, uint8_t* ___cn2, intptr_t ___cnLen3, unitytls_x509name_t8A1108C917795D8FE946B50769ACE51489C7BF5D* ___caList4, intptr_t ___caListLen5, unitytls_x509list_ref_t6C5C1CF0B720516A681CB741104A164FD8B3CF17* ___chain6, unitytls_key_ref_t6BD91D013DF11047C53738FEEB12CE290FDC71A2* ___key7, unitytls_errorstate_tC926EE4582920BE2C1DB1F3F65619B810D5AB902* ___errorState8);
extern "C" intptr_t CDECL ReversePInvokeWrapper_UnityTlsContext_ReadCallback_m068A7DC153B3D2C4F6922B46BC5957CF33AE3450(void* ___userData0, uint8_t* ___buffer1, intptr_t ___bufferLen2, unitytls_errorstate_tC926EE4582920BE2C1DB1F3F65619B810D5AB902* ___errorState3);
extern "C" uint32_t CDECL ReversePInvokeWrapper_UnityTlsContext_VerifyCallback_mC7AE01FAD8A336A6BF11CF8A3EFAC60CF6167E6F(void* ___userData0, unitytls_x509list_ref_t6C5C1CF0B720516A681CB741104A164FD8B3CF17 ___chain1, unitytls_errorstate_tC926EE4582920BE2C1DB1F3F65619B810D5AB902* ___errorState2);
extern "C" intptr_t CDECL ReversePInvokeWrapper_UnityTlsContext_WriteCallback_m74F83CFEE7D8FB7EBD1A1021DCB8945E89382998(void* ___userData0, uint8_t* ___data1, intptr_t ___bufferLen2, unitytls_errorstate_tC926EE4582920BE2C1DB1F3F65619B810D5AB902* ___errorState3);
extern "C" uint32_t CDECL ReversePInvokeWrapper_UnityTlsProvider_x509verify_callback_mB2465D108005179B9873A37C418CD26A37194E3B(void* ___userData0, unitytls_x509_ref_t9CEB17766B4144117333AB50379B21A357FA4333 ___cert1, uint32_t ___result2, unitytls_errorstate_tC926EE4582920BE2C1DB1F3F65619B810D5AB902* ___errorState3);


IL2CPP_EXTERN_C const Il2CppMethodPointer g_ReversePInvokeWrapperPointers[];
const Il2CppMethodPointer g_ReversePInvokeWrapperPointers[38] = 
{
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_AppHandle_HandleApiKeysCallback_mFCC2A906DAD8ACFB0078E79012753C3A3174D669),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_AppHandle_HandleLogMessage_m732A31DA5D0ECC68662E3CE12730C884BFDE5414),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_AppHandle_HandleStringCallback_mCFC9D3FA0F9FE704C08314103BE39681695F0349),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_AppHandle_HandleTaskCompletion_m29CBB73CE7AC5655DB9FD83045BE02D40377CCEB),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_AppHandle_HandleUserCallback_m59195C69F2CDFEFA5BE8947577B7E0F4BB05E049),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_CultureInfo_OnCultureInfoChangedInAppX_m407BCFC1029A4485B7B063BC2F3601968C3BE577),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_DeflateStreamNative_UnmanagedRead_m321A2621068F1C9509594A4D8F405F4F12C1CEB3),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_DeflateStreamNative_UnmanagedWrite_mB0AD438266A9DD2813715E8BC90BF07DC7A02F52),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_DictionaryHandle_NotifyDictionaryChanged_mD43B3CB619C94763E63B30753FDF8018D8F21CC2),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_HttpClientTransport_ExecuteRequest_m35290E89DDC84CD81E3946907D4FB5CAE9121205),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_NotifiableObjectHandleBase_NotifyObjectChanged_m66C86BA2E8E810BEA2AD2BACC5F0774B87127FC1),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_OSSpecificSynchronizationContext_InvocationEntry_mF93C3CF6DBEC86E377576D840CAF517CB6E4D7E3),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_SessionHandle_HandleSessionError_m3E24836C3BD6C888EBE26CF1005C6FB056C3ED92),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_SessionHandle_HandleSessionProgress_m97873A8809EF2B1B24D3F3497843BA0FD714859C),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_SessionHandle_HandleSessionPropertyChangedCallback_mE8B536808245CDAF0CBBFCDB9062B5F9559E1EC6),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_SessionHandle_HandleSessionWaitCallback_m11DBC1B9A62F91CBC6263D3B6BB3DC5859E408C7),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_SessionHandle_NotifyAfterClientReset_m6B7EFB5A4100182570E56B9983D731296D85D068),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_SessionHandle_NotifyBeforeClientReset_m2D4BD0DAA88BBBE0D14A702CFA8AB7D70723E4ED),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_SharedRealmHandle_DisposeGCHandleCallback_m668A07D0D17FEE9423E450E4DDC72A767CB10E0A),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_SharedRealmHandle_GetNativeSchema_mF6C796D3BCF7A47B591E1D42669A1E0EBCA15476),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_SharedRealmHandle_HandleOpenRealmCallback_m8C357CF44BD0E5FB927D311EA8B04A1E8E19417D),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_SharedRealmHandle_HandleTaskCompletionCallback_m8EFFD66BC7C8BC06B74728779E9C0C302330B6EB),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_SharedRealmHandle_LogMessage_m853C5563B02C3C419B2255F0205253A0420523C2),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_SharedRealmHandle_NotifyRealmChanged_m6E4E0156A94C47BAE7E3D16E7B1B53861ED2B1B7),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_SharedRealmHandle_OnDataInitialization_m0EADE39796EE67E85EACF81BC153FB607483B826),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_SharedRealmHandle_OnMigration_m13ACEC8D538DDCB3AD48A8E6B7E605D376C62355),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_SharedRealmHandle_ShouldCompactOnLaunchCallback_m87A2BDFF783115E2B6196050134B074E90525B44),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_SubscriptionSetHandle_HandleStateWaitCallback_mDE2E1712818EC4DDBEA971216031FBC17D480487),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_SubscriptionSetHandle_OnGetSubscription_m7077C72279810E74A35D83BC0F57ED0057CAF550),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_SynchronizationContextScheduler_GetCurrentSynchronizationContext_m0E56528172407B1E8D3EBA8423F9982695B70A5D),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_SynchronizationContextScheduler_IsOnSynchronizationContext_m4159E8B18883228BCAC16E4A7C2DDB14C1DB8BD2),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_SynchronizationContextScheduler_PostOnSynchronizationContext_m8164B6735EBD57EEAB505BD93070FDB107F24411),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_SynchronizationContextScheduler_ReleaseSynchronizationContext_m52779C54E97B974D691C6C9F560A15CE6C6C4FF6),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_UnityTlsContext_CertificateCallback_m8CC672A44A8CCFD2A3EB2D9B38A9A134F6EF706B),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_UnityTlsContext_ReadCallback_m068A7DC153B3D2C4F6922B46BC5957CF33AE3450),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_UnityTlsContext_VerifyCallback_mC7AE01FAD8A336A6BF11CF8A3EFAC60CF6167E6F),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_UnityTlsContext_WriteCallback_m74F83CFEE7D8FB7EBD1A1021DCB8945E89382998),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_UnityTlsProvider_x509verify_callback_mB2465D108005179B9873A37C418CD26A37194E3B),
};
