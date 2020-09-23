# All Possible Auto-path Generation List

The auto-path generator feature is a big time-saver for you by eliminating the need to think where to put all of your mod's AssetBundles.

But, even for auto-path generator, you need to know what auto-path is generating to find the bundles you've made in your zipmod archive.

Here is the list of all possible inputs you can use for the auto-path generator.

## Variable Legends

-   "Output Mod Name"

    This is the filename of your zipmod.

-   "Mod Identifier"

    This is the internal identifier for your zipmod. You can learn more about XML identifiers then go to [XML File Structure](technical/xml-file.md) Document.

-   "Auto-Path Category Identifier"

    This is the internal index for auto-path category. Mostly incremental value from 0 with few zero paddings.

## Generic Autopath

### For Textures

-   Examples

    ```xml
    <bundles>
        <bundle auto-path="texture">
            <asset path="path/to/asset" />
            ...
        </bundle>
        <bundle auto-path="textures">
            <asset path="path/to/asset" />
            ...
        </bundle>
        <folder auto-path="texture" />
        <folder auto-path="textures" />
        <each auto-path="texture" />
        <each auto-path="textures" />
    </bundles>
    ```

-   Output

    `abdata/[Output Mod Name]/[Mod Identifier]/data_texture_00000.unity3d`

### For Materials

-   Examples

    ```xml
    <bundles>
        <bundle auto-path="materials">
            <asset path="path/to/asset">
            ...
        </bundle>
        <bundle auto-path="material">
            <asset path="path/to/asset">
            ...
        </bundle>
        <folder auto-path="materials" />
        <folder auto-path="material" />
        <each auto-path="materials" />
        <each auto-path="material" />
    </bundles>
    ```

-   Output Target

    `abdata/[Output Mod Name]/[Mod Identifier]/data_material_00000.unity3d`

### For Map Scenes

-   Examples

    ```xml
    <bundles>
    <bundle auto-path="maps">
        <asset path="path/to/asset" />
        ...
    </bundle>
    <bundle auto-path="map">
        <asset path="path/to/asset" />
        ...
    </bundle>
    <folder auto-path="maps" />
    <folder auto-path="map" />
    <each auto-path="maps" />
    <each auto-path="map" />
    </bundles>
    ```

-   Output Target

    `abdata/[Output Mod Name]/[Mod Identifier]/data_scene_00000.unity3d`

### For Outfit Thumbnails

-   Examples

    !> Using `<each>` operation for the thumbnail is highly discouraged. try to use `<folder>`

    ```xml
    <bundles>
    <bundle auto-path="thumbnails">
        <asset path="path/to/asset" />
        ...
    </bundle>
    <bundle auto-path="thumbnail">
        <asset path="path/to/asset" />
        ...
    </bundle>
    <bundle auto-path="thumbs">
        <asset path="path/to/asset" />
        ...
    </bundle>
    <bundle auto-path="thumb">
        <asset path="path/to/asset" />
        ...
    </bundle>
    <folder auto-path="thumbnails" />
    <folder auto-path="thumbnail" />
    <folder auto-path="thumbs" />
    <folder auto-path="thumb" />
    <each auto-path="thumbnails" />
    <each auto-path="thumbnail" />
    <each auto-path="thumbs" />
    <each auto-path="thumb" />
    </bundles>
    ```

-   Output Target

    `abdata/[Output Mod Name]/[Mod Identifier]/data_thumbnail_00000.unity3d`

### For Generic Game Objects

-   Examples

    ```xml
    <bundles>
        ...
        <bundle auto-path="objects">
            <asset path="path/to/asset"/>
            ...
        </bundle>
        <bundle auto-path="object">
            <asset path="path/to/asset"/>
            ...
        </bundle>
        <bundle auto-path="prefabs">
            <asset path="path/to/asset"/>
            ...
        </bundle>
        <bundle auto-path="prefab">
            <asset path="path/to/asset"/>
            ...
        </bundle>
        <folder auto-path="objects" />
        <folder auto-path="object" />
        <folder auto-path="prefabs" />
        <folder auto-path="prefab" />
        <each auto-path="objects" />
        <each auto-path="object" />
        <each auto-path="prefabs" />
        <each auto-path="prefab" />
        ...
    </bundles>
    ```

-   Output Target

    `abdata/[Output Mod Name]/[Mod Identifier]/data_prefabs_00000.unity3d`

### For HS2 Main-Game Map Informations

-   Examples

    ```xml
    <bundles>
        ...
        <bundle auto-path="maps">
            <asset path="path/to/asset"/>
            ...
        </bundle>
        <bundle auto-path="map">
            <asset path="path/to/asset"/>
            ...
        </bundle>
        <folder auto-path="maps" />
        <folder auto-path="map" />
        <each auto-path="maps" />
        <each auto-path="map" />
        ...
    </bundles>
    ```

-   Output Target

    `abdata/map/list/mapinfo/[Mod Identifier]_mapdata_000.unity3d`

### For HS2 Main-Game Camera Data

-   Examples

    ```xml
    <bundles>
        ...
        <bundle auto-path="eventcg" parameter="Map Scene Name">
            <asset path="path/to/asset.asset"/>
            ...
        </bundle>
        <bundle auto-path="mapcamera" parameter="Map Scene Name">
            <asset path="path/to/asset.asset"/>
            ...
        </bundle>
        <folder auto-path="eventcg" from="folder name" parameter="Map Scene Name" />
        <folder auto-path="mapcamera" from="folder name" parameter="Map Scene Name" />
        <each auto-path="eventcg" from="folder name" parameter="Map Scene Name" />
        <each auto-path="mapcamera" from="folder name" parameter="Map Scene Name" />
        ...
    </bundles>
    ```

-   Output Target

    `abdata/adv/eventcg/[Map ID from Map Parameter].unity3d`

    ?> "Map Parameter" references `parameter` inside of bundle opration tag. Once the parameter is provided, mod.xml will automatically find the map id and rename your bundle in ILLUSION naming convention.

    !> This method could change in any time once one of modder (including me) finds better way to organize in-game resource management.

### For Game Objects with Automatic Dependency Split

-   Examples

    ```xml
    <bundles>
        ...
        <folder auto-path="objects-split" grouped="true" />
        <folder auto-path="object-split" grouped="true" />
        <folder auto-path="prefabs-split" grouped="true" />
        <folder auto-path="prefab-split" grouped="true" />
        ...
    </bundles>
    ```

-   Output Target

    `abdata/[Output Mod Name]/[Mod Identifier]/data_prefab_00000_000.unity3d`

### Copy&Moving Studio Thumbnails

-   Examples

    !> This auto-path parameter is only can be used for `<copy>` or `<move>` bundle operation!

    ```xml
    <bundles>
        ...
        <move auto-path="studiothumbs" from="thumbs" filter=".*\.png"/>
        <move auto-path="studiothumb" from="thumbs" filter=".*\.png"/>
        <move auto-path="studio-thumbs" from="thumbs" filter=".*\.png"/>
        <move auto-path="studio-thumb" from="thumbs" filter=".*\.png"/>
        <move auto-path="studiothumbnails" from="thumbs" filter=".*\.png"/>
        <move auto-path="studiothumbnail" from="thumbs" filter=".*\.png"/>
        <copy auto-path="studiothumbs" from="thumbs" filter=".*\.png"/>
        <copy auto-path="studiothumb" from="thumbs" filter=".*\.png"/>
        <copy auto-path="studio-thumbs" from="thumbs" filter=".*\.png"/>
        <copy auto-path="studio-thumb" from="thumbs" filter=".*\.png"/>
        <copy auto-path="studiothumbnails" from="thumbs" filter=".*\.png"/>
        <copy auto-path="studiothumbnail" from="thumbs" filter=".*\.png"/>
        ...
    </bundles>
    ```

-   Output Target

    `abdata/[Output Mod Name]/[Mod Identifier]/data_material_00000.unity3d`
