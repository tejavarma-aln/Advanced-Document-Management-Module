# Advanced-Document-Management-Module
Link Documents with Vouchers and Masters 

## Link Multiple Documents for any voucher
## Register the DLL DocumentLinker.dll for file Dialog support

**Get Started**

-> Download the files Documentlinker.dll , DocumentLinker.txt
-> Register the DLL as mention below
-> Load DocumentLinker.txt in tally as normal TDL
-> You will find an option at bottom of every voucher (Set/Alter Document Details ) dhich allows to Link documents
-> Select multiple options(Yes/No) or click SELECT MULTIPLE button vice-versa which allows to select multiple documents
-> Click SHOW DOCUMENTS button to display the linked documents
-> In List of Documents Select the Document (one at a time) by hitting Space Bar and click OPEN button the View the document
-> Optionally You can enter description/narration 

**Registering DLL**

1) Open CMD in administrator Mode (Elevated mode)

           For 64 Bit
2) Type cd C:\Windows\Microsoft.NET\Framework64\v4.0.30319   ;;change directory

           For 32 Bit
2) Type cd C:\Windows\Microsoft.NET\Framework\v4.0.30319  ;;change directory


3) Type  regasm Documentlinker.dll /codebase   ;;Give Full path of the Documentlinker.dll.dll file and give space then enter /codebase

4) You will get success message after it registered

**Requirements**

-> .Net Framework 4.x.x 
     
     You can Download from here : https://dotnet.microsoft.com/download/dotnet-framework/net40
