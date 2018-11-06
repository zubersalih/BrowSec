# Introduction
- BrowSec is a POC(Proof-Of-Conecept) tool that demonstrates what can a malware do to your (Chromium) Based Browser .
- most of the POC this tool implemented is publicly released techniques.
- all of them were reported and google security team denied to fix them and their reason is "if the attacker have (physical) access to your machine they can do worse.
- i will try to add support for **Android , OSX, Linux**
# 1 Password Stealer

- Chrome or any other Chromium based browser's stores "Saved Password" in a local sqlite database file and the password value is 
encrypted and decrypted
using windows built in Security and Identity's [DPAPI.H](https://docs.microsoft.com/en-us/windows/desktop/api/dpapi/index) api.

**N.B data encrypted using DPAPI.H can only be decrypted on the machine it was encrypted**

DPAPI function to  encrypt data
```
DPAPI_IMP BOOL CryptProtectData(
  DATA_BLOB                 *pDataIn,
  LPCWSTR                   szDataDescr,
  DATA_BLOB                 *pOptionalEntropy,
  PVOID                     pvReserved,
  CRYPTPROTECT_PROMPTSTRUCT *pPromptStruct,
  DWORD                     dwFlags,
  DATA_BLOB                 *pDataOut
);
```

DPAPI function To Decrypt data
```
DPAPI_IMP BOOL CryptUnprotectData(
  DATA_BLOB                 *pDataIn,
  LPWSTR                    *ppszDataDescr,
  DATA_BLOB                 *pOptionalEntropy,
  PVOID                     pvReserved,
  CRYPTPROTECT_PROMPTSTRUCT *pPromptStruct,
  DWORD                     dwFlags,
  DATA_BLOB                 *pDataOut
);
```
- but chrome encrypts passwords using below parameteres
```
CryptProtectData(
      { cbData: 28, pbData: "actual password" },
      "The password for the site",
      null, //optional entropy
      null, //reserved
      null, //prompt options
      0, //flags
      { cbData:   pbData:  });
 ```
 - as you can see they are passing the ```entropy``` parameter as ```null``` which means anybody with access to the machine can decrypt the 
 encrypted data even if they(Google) passed a private key to that parameter they still have to store it somewhere but can only be decrypted locally.
- so anybody can just retrieve the ```password_value``` and decrypt it by using the same DPAPI.H function's ```CryptUnProtectData({...```
# 2 :wink: :wink: will be released after some hours
# Future Works
[ ] It's a surprise
