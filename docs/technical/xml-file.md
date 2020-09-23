# The Structure of Mod XML File

## What is it

mod.xml is a file that stores all of the information of the mod that you're going to make.

## Why XML?

For now, without UI, XML is the fastest and most friendly way to organize most of the things in one single look.
I'm planning to add less complex GUI to make it more accessible for more people, so for now, let's wait :^)

## Overview

```xml
<packer>
	<guid></guid>
    <name></name>
    <version></version>
    <author></author>
    <mod-id></mod-id>
    <description></description>
    <options>
        <use-dependency />
    </options>
    <bundles>
    </bundles>
    <builds>
    </builds>
</packer>
```

### Essentials

#### **Packer Root Node**

```xml
<packer>
	...
</packer>
```

Every single line should be wrapped with a packer. Just remember this one.

?> You can add any other nodes as long as you can, but _I don't recommend_ adding anything that is not <packer> at the root level.

#### **GUID**

```xml
<packer>
	<guid> ... </guid>
</packer>
```

GUID is one of the main elements that the Sideloader plugin distinguishes the mod from the other mod.

This GUID value MUST BE UNIQUE to ALL OTHER ZIPMODS, or it will conflict with other mods, and you're going to have a real bad time.

Sideloader is not enforcing the zipmod's GUID format, but I recommend you to follow these rule:

-   make GUID all lowercase
-   make GUID in `author.bigcategory.midcategory.name.name2` format
-   not including any special characters but '.' in GUID

?> Sideloader will load zipmod with faulty names but when it comes to plugin development, extra charset could be really bad time for plugin developers.

#### **Name**

```xml
<packer>
	<name> ... </name>
</packer>
```

As the title says, this is the name of your zipmod. Unlike GUID, I recommend you to set a nice human-readable name in that place.
It is a good idea to write the zipmod's name in English, so most people on the internet have some hint.
This value is one of the most utilized values by other plugins and tools. Please give it a nice touch so everyone can have a happy time.

#### **Version**

```xml
<packer>
    <version>1.0.0</version>
</packer>
```

The sideloader plugin uses this value to determine which mod is the latest.

It means you can easily update your mod without conflicting your old mods even if anyone decided to store all of your mod in the active mod folder for some reason.

Unfortunately, Sideloader requires the version values to be in [Semantic Versioning](https://semver.org/) Format.
So, you can't just put random values in this version tag.

Please put the value in `X.Y.Z` format if you want to full specification of [Semantic Versioning](https://semver.org/)

You only can put numbers in version value.

#### **Author**

```xml
<packer>
	<author> ... </author>
</packer>
```

Change this value if you want to let people know that you've made this mod.

It is recommended to fill this out since this is one of the values used for automatic path assignment.

#### **Bundles**

```xml
<packer>
	<bundles>
    	...
    </bundles>
</packer>
```

The tags under `<bundles>` is called **Bundle Operators**.

-   **move**

    ```xml
    <bundles>
    	<move from="source folder" to="dest folder" filter=".*\.extension"/>
        <move from="source folder" auto-path="target auto-path" filter="regex filter" />
        ...
    </bundles>
    ```

    The tag that makes the mod packer will copy all of the files inside of this folder to the zipmod folder.

-   **each**

    ```xml
    <bundles>
        <each from="source folder" path="dest path" filter=".\.extension"/>
        <each from="source folder" auto-path="target auto-path" filter=".\.extension"/>
    	...
    </bundles>
    ```

    The tag that makes the mod packer will pack prefab/assets to each bundle.

-   **folder**

    ```xml
    <bundles>
        <folder from="source folder" path="dest path" filter=".\.extension"/>
        <folder from="source folder" auto-path="target auto-path" filter=".\.extension"/>
        <folder from="source folder" auto-path="target auto-path" filter="filter" grouped="true" />
        ...
    </bundles>
    ```

    The tag that makes the mod packer will pack prefabs/assets in the folder into a bundle.

    ?> Grouped attribute only effective when `<use-dependency/>` option is present in options tag.

    ?> You cannot control group rules at this moment.

-   **bundle**

    ```xml
    <bundles>
    	<bundle path="">
      	<asset path=""/>
            ...
        </bundle>
        ...
    </bundles>

    ```

    The tag that defines what to be packed

    -   **asset**

        The tag that defines what to be packed

#### Builds

```xml
<packer name="">
    <list>
        <item/>
        ...
    </list>
    ...
</packer>
```

-   **list**

    The tag mod packer uses to generate a CSV file to make the game recognize what to load.

### Optionals

#### Modding Tool Specific ID

```xml
<packer>
	<mod-id> ... </mod-id>
</packer>
```

Mod-id is the output name of your zipmod.
when the mod is getting built, it will pack all of your mod files and name the mod file to this variable

This variable is just made for my convenience. Feel free to use this variable if you like my style.

#### Additional Options

```xml
<packer>
	<options>
    	<use-dependency/>
    </options>
    ...
</packer>
```

-   use-dependency

    Just add `<use-dependency>` when you want to pack your mod into several dependency bundles to decrease the size and increase mod loading time.
    If you put `<use-dependecny>` in the option, your mod becomes dependent on the Dependency Loader plugin.
    The mod packer automatically calculates everything, so don't worry about rigging your mod for the plugin.

    ?> Once you decided to use Dependency Loader option, you must reference [Dependency Loader Plugin Repository](https://github.com/hooh-hooah/DependencyLoader/releases) in order to make people use your mod properly.
