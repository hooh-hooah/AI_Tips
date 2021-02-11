# Debugging Plugin

## How it works

Mono-Remote Debugger allows you to debug the game without struggling with a lot of log messages. 

With dnSpy's author's help, we can use mono debugger with simple setup - by replacing modo dll file of the game.

## Using dnSpy

## Using Rider

You can break your plugin's code in IDE with some tricky settings.

1. Setting up "Standalone Player" 
```
Exe Path = "Game's Executable Path"
Working Directory = "Game's Executable Directory"
```
2. Setting up Mono Remote
```
Host localhost
Port 55555     #dnspy mono's default port
```
3. Setting up Compound
```
Run 1 and 2 tasks at the same time.
```
4. Changing the BepInEx Setting
```ini
## If enabled, BepInEx will load patched assemblies from BepInEx/DumpedAssemblies instead of memory.
## This can be used to be able to load patched assemblies into debuggers like dnSpy.
## If set to true, will override DumpAssemblies.
# Setting type: Boolean
# Default value: false
LoadDumpedAssemblies = true # change this value to true
```

Run "Debugger Compound" to debug and enjoy the breakpoint

## Using Visual Studio