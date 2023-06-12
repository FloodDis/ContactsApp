#define MyAppName "ContactsApp"
#define MyAppVersion "1.0.0"
#define MyAppPublisher "Vladislav Sechenov"
#define MyAppURL "https://github.com/FloodDis/ContactsApp"
#define Configuration "Release"
#define MyAppExeName "ContactsApp.View.exe"
#define InstallerFileName "ContactsAppSetup " + GetDateTimeString('dd-mm-yyyy hh-nn-ss', '-', ':');
#define SourceFiles "..\src\ContactsApp.View\bin\" + Configuration + "\net6.0-windows"

[Setup]
AppId={{631C5F5A-18EC-4C5B-8A83-7AD08DB8E96C}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\SechenovVV\{#MyAppName}
ChangesAssociations=yes
DefaultGroupName={#MyAppName}
AllowNoIcons=yes
OutputDir=.\Output
OutputBaseFilename={#InstallerFileName}
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "{#SourceFiles}\{#MyAppExeName}"; DestDir: "{autopf}\SechenovVV\{#MyAppName}"; Flags: ignoreversion
Source: "{#SourceFiles}\*.dll"; DestDir: "{autopf}\SechenovVV\{#MyAppName}"; Flags: ignoreversion
Source: "{#SourceFiles}\*.runtimeconfig.json"; DestDir: "{autopf}\SechenovVV\{#MyAppName}"; Flags: ignoreversion

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent
