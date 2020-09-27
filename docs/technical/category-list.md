# ALL Possbiel XML List Types

?> Most of them work, there might be edge case that I couldn't tested. Since the Document is really long, I suggest you to search around with Ctrl+F key.

## All Possible Studio Category List

### Big Category

```xml
<list type="bigcategory">
  <item id="number" name="category name">
</list>
```

-   Key Name: `bigcategory`
-   Description: Studio Item Big Category
-   Key List
    -   `id`: id of Big Category must be unique
    -   `name`: The name of Big Category

### Mid Category

```xml
<list type="midcategory">
  <item big-category="number" id="number" name="category name">
</list>
```

-   Key Name: `midcategory`
-   Description: Studio Item Mid Category
-   Key List
    -   `id`: id of Mid Category must be unique to big category.
    -   `big-category`: id of Big Category
    -   `name`: The name of Mid Category

### Studio Item

```xml
<list type="props">
  <item big-category="number" mid-category="number" name="name" object="prefab's name">
</list>
```

-   Key Name: `studioitem` or `props`
-   Description: Studio Item
-   Key List
    -   `big-category`: The ID of Animation Big Category
    -   `mid-category`: The ID of Animation Mid Category
    -   `name`: The name of the animation
    -   `manifest`: (Automatically Resolved by default) the manifest name of the item
    -   `id`: (Automatically Resolved by default) the id of the item
    -   `object-bundle`: (Automatically Resolved by default) The path to the bundle where `object` is stored.
    -   `object`: The prefab's name

### Studio Map

```xml
<list type="map">
  <item name="mapname" scene="scenasset">
</list>
```

-   Key Name: `map`
-   Description: Studio Map Mod
-   Key List
    -   `id`: description

### Animation Big Category

```xml
<list type="animebigcategory">
  <item id="number" name="category name">
</list>
... or ...
<list type="animationmidcategory">
  <item id="number" name="category name">
</list>
```

-   Key Name: `animebigcategory` or `animationbigcategory`
-   Description: Animation Big Category
-   Key List
    -   `id`: id of Animation Big Category
        must be unique to all game
    -   `name`: The name of Animation Big Category

### Animation Small Category

```xml
<list type="animemidcategory">
    <item id="number" name="category name">
</list>
... or ...
<list type="animationmidcategory">
    <item id="number" name="category name">
</list>
```

-   Key Name: `animemidcategory` or `animationmidcategory`
-   Description: Animation Mid Category
-   Key List
    -   `id`: id of Animation Mid Category
        must be unique to sideloader GUID
    -   `name`: The name of Animation Mid Category

### Animation

```xml
<list type="animation">
  <item
    big-category="big category id*" mid-category="mid category id"
    name="name" anime-controller="animation controller asset"
    anime="state inside of animator controller asset"
    />
</list>
```

-   Key Name: `anime` or `animation`
-   Description: Animation Category
-   Key List
    -   `big-category`: The ID of Animation Big Category
    -   `mid-category`: The ID of Animation Mid Category
    -   `name`: The name of the animation
    -   `anime-controller`: The [Animator Controller](https://docs.unity3d.com/Manual/class-AnimatorController.html) asset name
    -   `anime`: The state name inside of animator controller

## All Possible Character Category List

### Male Head

```xml
<list type="mhead">
  <item id="" manifest="" kind="" possess="" en_us="" thumb-bundle="" thumb="">
</list>
```

-   Key Name: `mhead`
-   Description: Male Head
-   Key List
    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.

### Male Face Skin

```xml
<list type="mskinf">
  <item id="" manifest="" kind="" possess="" en_us=""
   thumb-bundle="" thumb="" tex-bundle="" tex-a="" />
</list>
```

-   Key Name: `mskinf`
-   Description: Male Face Skin
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `tex-bundle`: The bundle path for the `tex-*` assets.
    -   `tex-a`: The diffuse texture.
    -   `tex-o`: The occlusion texture.
    -   `tex-n`: The normalmap texture.
    -   `head-id`: The head id of the texture. Face texture is Face-type dependent. Make sure that your texture is referencing correct face type.

### Male Face Detail

```xml
<list type="mdetailf">
  <item id="" manifest="" kind="" possess="" en_us=""
   thumb-bundle="" thumb="" tex-bundle="" tex-a="" />
</list>
```

-   Key Name: `mdetailf`
-   Description: Male Face Detail
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `tex-bundle`: The bundle path for the `tex-*` assets.
    -   `tex-a`: The diffuse texture.

### Male Beard Texture

```xml
<list type="mbeard">
  <item id="" manifest="" kind="" possess="" en_us=""
   thumb-bundle="" thumb="" tex-bundle="" tex-a="" />
</list>
```

-   Key Name: `mbeard`
-   Description: Male Beard
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `tex-bundle`: The bundle path for the `tex-*` assets.
    -   `tex-a`: The diffuse texture.

### Male Body Skin

```xml
<list type="mskinb">
  <item id="" manifest="" kind="" possess="" en_us=""
   thumb-bundle="" thumb="" tex-bundle="" tex-a="" />
</list>
```

-   Key Name: `mskinb`
-   Description: Male Skin Body
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `tex-bundle`: The bundle path for the `tex-*` assets.
    -   `tex-a`: The diffuse texture.

### Male Body Detail

```xml
<list type="mdetailb">
  <item id="" manifest="" kind="" possess="" en_us=""
   thumb-bundle="" thumb="" tex-bundle="" tex-o="" tex-n=""/>
</list>
```

-   Key Name: `mdetailb`
-   Description: Male Skin Detail
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `tex-bundle`: The bundle path for the `tex-*` assets.
    -   `tex-a` or `tex-o`: The occlusion texture.
    -   `tex-n`: The normalmap texture.

### Male Sunburn

```xml
<list type="msunburn">
  <item id="" manifest="" kind="" possess="" en_us=""
   thumb-bundle="" thumb="" tex-bundle="" tex-a="" />
</list>
```

-   Key Name: `msunburn`
-   Description: Male Sunburn
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `tex-bundle`: The bundle path for the `tex-*` assets.
    -   `tex-a`: The diffuse texture.

### Male Top

```xml
<list type="mtop">
  <item id="" manifest="" kind="" possess="" en_us="" thumb-bundle="" thumb=""
    state="" mesh-bundle="" mesh-a="" tex-bundle="" tex-main="" tex-mask=""
    tex-main2="" tex-mask2="" coordinate="" overbra-type="" overbra-tex=""
    overbra-bundle="" bodymask-tex="" bodymask-bundle="" bramask-tex=""
    breakmask-tex="" bramask-bundle="" innermask-tb-tex="" innermask-tb-bundle=""
    innermask-b-tex="" innermask-b-bundle="" panstmask-tex="" panstmask-bundle=""
    bodymask-b-tex="" bodymask-b-bundle="" tex-main3="" tex-mask3="" />
      <item
    id="" manifest="" kind="" possess="" en_us="" thumb-bundle="" thumb=""
    state="" mesh-bundle="" mesh-a="" tex-bundle="" tex-main=""
    tex-mask="" tex-main2="" tex-mask2=""
  />
</list>
```

-   Key Name: `mtop`
-   Description: Male Top Clothing
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `state`:
        -   `0`: This item doesn't have half-off state.
        -   `1`: This item has half-off state.
    -   `mesh-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `mesh-a`: The name of the clothing prefab
    -   `tex-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `tex-main`: The name of the diffuse texture of clothing. Used for changing Color1 in the game.
    -   `tex-mask`: The name of the colormask texture of clothing. Used for changing Color1 in the game.
    -   `tex-main2`: The name of the diffuse texture of clothing. Used for changing Color2 in the game.
    -   `tex-mask2`: The name of the colormask texture of clothing. Used for changing Color2 in the game.
    -   `coordinate`:
        -   `0`: Normal Clothing
        -   `1`: Set Clothing (Takes top and bottom slot at the same time).
    -   `overbra-type`: This value is not used nor referenced in the game.
    -   `overbra-tex`: The name of the alpha mask texture for bra.
    -   `overbra-bundle`: The bundle path for the bra alphamask texture.
    -   `bodymask-tex`: The name of the alphamask for upper body
    -   `bodymask-bundle`: The bundle path for the upper body alphamask texture.
    -   `bramask-tex`: The name of the alphamask texture for innertop.
    -   `breakmask-tex`: The name of the alphamask for cloth tearing
    -   `bramask-bundle`: The bundle path for the bra alphamask texture.
    -   `innermask-tb-tex`: The name of the alphamask texture for coordinate type innertop.
    -   `innermask-tb-bundle`: The bundle path for the coordinate type innertop alphamask texture.
    -   `innermask-b-tex`: The name of the alphamask texture for innerbottom.
    -   `innermask-b-bundle`: The bundle path for the innerbottom alphamask texture.
    -   `panstmask-tex`: The name of the alphamask texture for pantystocking.
    -   `panstmask-bundle`: The bundle path for the pantystocking alphamask texture.
    -   `bodymask-b-tex`: The name of the alphamask texture for bottom body.
    -   `bodymask-b-bundle`: The bundle path for the bottom body alphamask texture.
    -   `tex-main3`: The name of the diffuse texture of clothing. Used for changing Color3 in the game.
    -   `tex-mask3`: The name of the colormask texture of clothing. Used for changing Color3 in the game.

### Male Bottom

```xml
<list type="mbottom">
  <item
    id="" manifest="" kind="" possess="" en_us="" thumb-bundle="" thumb=""
    state="" mesh-bundle="" mesh-a="" tex-bundle="" tex-main="" tex-mask=""
    tex-main2="" tex-mask2="" breakmask-tex="" bramask-bundle="" innermask-tb-tex=""
    innermask-tb-bundle="" innermask-b-tex="" innermask-b-bundle="" panstmask-tex=""
    panstmask-bundle="" bodymask-b-tex="" bodymask-b-bundle="" tex-main3="" tex-mask3=""
  />
    <item
    id="" manifest="" kind="" possess="" en_us="" thumb-bundle="" thumb=""
    state="" mesh-bundle="" mesh-a="" tex-bundle="" tex-main=""
    tex-mask="" tex-main2="" tex-mask2=""
  />
</list>
```

-   Key Name: `mbottom`
-   Description: Bottom Clothing
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `state`:
        -   `0`: This item doesn't have half-off state.
        -   `1`: This item has half-off state.
    -   `mesh-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `mesh-a`: The name of the clothing prefab
    -   `tex-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `tex-main`: The name of the diffuse texture of clothing. Used for changing Color1 in the game.
    -   `tex-mask`: The name of the colormask texture of clothing. Used for changing Color1 in the game.
    -   `tex-main2`: The name of the diffuse texture of clothing. Used for changing Color2 in the game.
    -   `tex-mask2`: The name of the colormask texture of clothing. Used for changing Color2 in the game.
    -   `breakmask-tex`: The name of the alphamask for cloth tearing
    -   `bramask-bundle`: The bundle path for the bra alphamask texture.
    -   `innermask-tb-tex`: The name of the alphamask texture for coordinate type innertop.
    -   `innermask-tb-bundle`: The bundle path for the coordinate type innertop alphamask texture.
    -   `innermask-b-tex`: The name of the alphamask texture for innerbottom.
    -   `innermask-b-bundle`: The bundle path for the innerbottom alphamask texture.
    -   `panstmask-tex`: The name of the alphamask texture for pantystocking.
    -   `panstmask-bundle`: The bundle path for the pantystocking alphamask texture.
    -   `bodymask-b-tex`: The name of the alphamask texture for bottom body.
    -   `bodymask-b-bundle`: The bundle path for the bottom body alphamask texture.
    -   `tex-main3`: The name of the diffuse texture of clothing. Used for changing Color3 in the game.
    -   `tex-mask3`: The name of the colormask texture of clothing. Used for changing Color3 in the game.

### Male Gloves

```xml
<list type="mgloves">
 <item
    id="" manifest="" kind="" possess="" en_us="" thumb-bundle="" thumb=""
    state="" mesh-bundle="" mesh-a="" tex-bundle="" tex-main=""
    tex-mask="" tex-main2="" tex-mask2=""
  />
</list>
```

-   Key Name: `mgloves`
-   Description: Male Gloves
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `state`:
        -   `0`: This item doesn't have half-off state.
        -   `1`: This item has half-off state.
    -   `mesh-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `mesh-a`: The name of the clothing prefab
    -   `tex-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `tex-main`: The name of the diffuse texture of clothing. Used for changing Color1 in the game.
    -   `tex-mask`: The name of the colormask texture of clothing. Used for changing Color1 in the game.
    -   `tex-main2`: The name of the diffuse texture of clothing. Used for changing Color2 in the game.
    -   `tex-mask2`: The name of the colormask texture of clothing. Used for changing Color2 in the game.

### Male Shoes

```xml
<list type="mshoes">
 <item
    id="" manifest="" kind="" possess="" en_us="" thumb-bundle="" thumb=""
    state="" mesh-bundle="" mesh-a="" tex-bundle="" tex-main=""
    tex-mask="" tex-main2="" tex-mask2=""
  />
</list>
```

-   Key Name: `mshoes`
-   Description: Male Shoes
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `state`:
        -   `0`: This item doesn't have half-off state.
        -   `1`: This item has half-off state.
    -   `mesh-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `mesh-a`: The name of the clothing prefab
    -   `tex-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `tex-main`: The name of the diffuse texture of clothing. Used for changing Color1 in the game.
    -   `tex-mask`: The name of the colormask texture of clothing. Used for changing Color1 in the game.
    -   `tex-main2`: The name of the diffuse texture of clothing. Used for changing Color2 in the game.
    -   `tex-mask2`: The name of the colormask texture of clothing. Used for changing Color2 in the game.

### Female Head

```xml
<list type="fhead">
  <item id="" manifest="" kind="" possess="" en_us="" thumb-bundle="" thumb="">
</list>
```

-   Key Name: `fhead`
-   Description: Female Head
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `head-object`: The name of the head prefab asset.
    -   `head-bundle`: The path of assetbundle for the head prefab asset.
    -   `shape-anime`: The name of the head morph asset. The face information is hardcoded to `list/customshape.unity3d`
    -   `mat-data`: Custom material information for rendering the face. References from `head-bundle`. `ChaControl.InitBaseCustomTextureFace` is utilizing this value.
    -   `preset`: Loads face preset from the `head-bundle`. Messagepack seralized file is required.

### Female Face Skin

```xml
<list type="fskinf">
  <item id="" manifest="" kind="" possess="" en_us=""
   thumb-bundle="" thumb="" tex-bundle="" tex-a="" />
</list>
```

-   Key Name: `fskinf`
-   Description: Female Face Skin
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `tex-bundle`: The bundle path for the `tex-*` assets.
    -   `tex-a`: The diffuse texture.
    -   `tex-o`: The occlusion texture.
    -   `tex-n`: The normalmap texture.
    -   `head-id`: The head id of the texture. Face texture is Face-type dependent. Make sure that your texture is referencing correct face type.

### Female Face Detail

```xml
<list type="fdetailf">
  <item id="" manifest="" kind="" possess="" en_us=""
   thumb-bundle="" thumb="" tex-bundle="" tex-a="" />
</list>
```

-   Key Name: `fdetailf`
-   Description: Female Face Detail
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `tex-bundle`: The bundle path for the `tex-*` assets.
    -   `tex-a`: The diffuse texture.

### Female Body Skin

```xml
<list type="fskinb">
  <item id="" manifest="" kind="" possess="" en_us=""
   thumb-bundle="" thumb="" tex-bundle="" tex-a="" />
</list>
```

-   Key Name: `fskinb`
-   Description: Female Skin Body
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `tex-bundle`: The bundle path for the `tex-*` assets.
    -   `tex-a`: The diffuse texture.

### Female Body Detail

```xml
<list type="fdetailb">
  <item id="" manifest="" kind="" possess="" en_us=""
   thumb-bundle="" thumb="" tex-bundle="" tex-o="" tex-n=""/>
</list>
```

-   Key Name: `fdetailb`
-   Description: Female Skin Detail
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `tex-bundle`: The bundle path for the `tex-*` assets.
    -   `tex-a` or `tex-o`: The occlusion texture.
    -   `tex-n`: The normalmap texture.

### Female Sun Burn

```xml
<list type="fsunburn">
  <item id="" manifest="" kind="" possess="" en_us=""
   thumb-bundle="" thumb="" tex-bundle="" tex-a="" />
</list>
```

-   Key Name: `fsunburn`
-   Description: Female Sunburn
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `tex-bundle`: The bundle path for the `tex-*` assets.
    -   `tex-a`: The diffuse texture.

### Female Top

```xml
<list type="ftop">
 <item
    id="" manifest="" kind="" possess="" en_us="" thumb-bundle="" thumb=""
    state="" mesh-bundle="" mesh-a="" tex-bundle="" tex-main=""
    tex-mask="" tex-main2="" tex-mask2=""
  />
</list>
```

-   Key Name: `ftop`
-   Description: Female Top Clothing
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `state`:
        -   `0`: This item doesn't have half-off state.
        -   `1`: This item has half-off state.
    -   `mesh-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `mesh-a`: The name of the clothing prefab
    -   `tex-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `tex-main`: The name of the diffuse texture of clothing. Used for changing Color1 in the game.
    -   `tex-mask`: The name of the colormask texture of clothing. Used for changing Color1 in the game.
    -   `tex-main2`: The name of the diffuse texture of clothing. Used for changing Color2 in the game.
    -   `tex-mask2`: The name of the colormask texture of clothing. Used for changing Color2 in the game.
    -   `coordinate`:
        -   `0`: Normal Clothing
        -   `1`: Set Clothing (Takes top and bottom slot at the same time).
    -   `no-bra`: Disable inner-top slot while this item is active.

### Female Bottom Clothing

```xml
<list type="fbottom">
  <item
    id="" manifest="" kind="" possess="" en_us="" thumb-bundle="" thumb=""
    state="" mesh-bundle="" mesh-a="" tex-bundle="" tex-main="" tex-mask=""
    tex-main2="" tex-mask2="" breakmask-tex="" bramask-bundle="" innermask-tb-tex=""
    innermask-tb-bundle="" innermask-b-tex="" innermask-b-bundle="" panstmask-tex=""
    panstmask-bundle="" bodymask-b-tex="" bodymask-b-bundle="" tex-main3="" tex-mask3=""
  />
    <item
    id="" manifest="" kind="" possess="" en_us="" thumb-bundle="" thumb=""
    state="" mesh-bundle="" mesh-a="" tex-bundle="" tex-main=""
    tex-mask="" tex-main2="" tex-mask2=""
  />
</list>
```

-   Key Name: `fbottom`
-   Description: Female Bottom Clothing
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `state`:
        -   `0`: This item doesn't have half-off state.
        -   `1`: This item has half-off state.
    -   `mesh-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `mesh-a`: The name of the clothing prefab
    -   `tex-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `tex-main`: The name of the diffuse texture of clothing. Used for changing Color1 in the game.
    -   `tex-mask`: The name of the colormask texture of clothing. Used for changing Color1 in the game.
    -   `tex-main2`: The name of the diffuse texture of clothing. Used for changing Color2 in the game.
    -   `tex-mask2`: The name of the colormask texture of clothing. Used for changing Color2 in the game.
    -   `breakmask-tex`: The name of the alphamask for cloth tearing
    -   `bramask-bundle`: The bundle path for the bra alphamask texture.
    -   `innermask-tb-tex`: The name of the alphamask texture for coordinate type innertop.
    -   `innermask-tb-bundle`: The bundle path for the coordinate type innertop alphamask texture.
    -   `innermask-b-tex`: The name of the alphamask texture for innerbottom.
    -   `innermask-b-bundle`: The bundle path for the innerbottom alphamask texture.
    -   `panstmask-tex`: The name of the alphamask texture for pantystocking.
    -   `panstmask-bundle`: The bundle path for the pantystocking alphamask texture.
    -   `bodymask-b-tex`: The name of the alphamask texture for bottom body.
    -   `bodymask-b-bundle`: The bundle path for the bottom body alphamask texture.
    -   `tex-main3`: The name of the diffuse texture of clothing. Used for changing Color3 in the game.
    -   `tex-mask3`: The name of the colormask texture of clothing. Used for changing Color3 in the game.

### Female Inner Top

```xml
<list type="fintop">
  <item
    id="" manifest="" kind="" possess="" en_us="" thumb-bundle="" thumb=""
    state="" mesh-bundle="" mesh-a="" tex-bundle="" tex-main="" tex-mask=""
    tex-main2="" tex-mask2="" hide-bottom="" coordinate="" overbra-type=""
    overbra-tex="" overbra-bundle="" bodymask-tex="" bodymask-bundle=""
    bramask-tex="" breakmask-tex="" bramask-bundle="" innermask-tb-tex=""
    innermask-tb-bundle="" innermask-b-tex="" innermask-b-bundle="" panstmask-tex=""
    panstmask-bundle="" bodymask-b-tex="" bodymask-b-bundle=""
    tex-main3="" tex-mask3=""
  />
    <item
    id="" manifest="" kind="" possess="" en_us="" thumb-bundle="" thumb=""
    state="" mesh-bundle="" mesh-a="" tex-bundle="" tex-main=""
    tex-mask="" tex-main2="" tex-mask2=""
  />
</list>
```

-   Key Name: `fintop`
-   Description: Female Inner Top Clothing
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `state`:
        -   `0`: This item doesn't have half-off state.
        -   `1`: This item has half-off state.
    -   `mesh-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `mesh-a`: The name of the clothing prefab
    -   `tex-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `tex-main`: The name of the diffuse texture of clothing. Used for changing Color1 in the game.
    -   `tex-mask`: The name of the colormask texture of clothing. Used for changing Color1 in the game.
    -   `tex-main2`: The name of the diffuse texture of clothing. Used for changing Color2 in the game.
    -   `tex-mask2`: The name of the colormask texture of clothing. Used for changing Color2 in the game.
    -   `hide-bottom`: Whether the item is disabling rendering the bottom or not.
    -   `coordinate`:
        -   `0`: Normal Clothing
        -   `1`: Set Clothing (Takes top and bottom slot at the same time).
    -   `overbra-type`: This value is not used nor referenced in the game.
    -   `overbra-tex`: The name of the alpha mask texture for bra.
    -   `overbra-bundle`: The bundle path for the bra alphamask texture.
    -   `bodymask-tex`: The name of the alphamask for upper body
    -   `bodymask-bundle`: The bundle path for the upper body alphamask texture.
    -   `bramask-tex`: The name of the alphamask texture for innertop.
    -   `breakmask-tex`: The name of the alphamask for cloth tearing
    -   `bramask-bundle`: The bundle path for the bra alphamask texture.
    -   `innermask-tb-tex`: The name of the alphamask texture for coordinate type innertop.
    -   `innermask-tb-bundle`: The bundle path for the coordinate type innertop alphamask texture.
    -   `innermask-b-tex`: The name of the alphamask texture for innerbottom.
    -   `innermask-b-bundle`: The bundle path for the innerbottom alphamask texture.
    -   `panstmask-tex`: The name of the alphamask texture for pantystocking.
    -   `panstmask-bundle`: The bundle path for the pantystocking alphamask texture.
    -   `bodymask-b-tex`: The name of the alphamask texture for bottom body.
    -   `bodymask-b-bundle`: The bundle path for the bottom body alphamask texture.
    -   `tex-main3`: The name of the diffuse texture of clothing. Used for changing Color3 in the game.
    -   `tex-mask3`: The name of the colormask texture of clothing. Used for changing Color3 in the game.

### Female Inner Bottom

```xml
<list type="finbottom">
 <item
    id="" manifest="" kind="" possess="" en_us="" thumb-bundle="" thumb=""
    state="" mesh-bundle="" mesh-a="" tex-bundle="" tex-main=""
    tex-mask="" tex-main2="" tex-mask2=""
  />
</list>
```

-   Key Name: `finbottom`
-   Description: Female Inner Bottom Clothing
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `state`:
        -   `0`: This item doesn't have half-off state.
        -   `1`: This item has half-off state.
    -   `mesh-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `mesh-a`: The name of the clothing prefab
    -   `tex-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `tex-main`: The name of the diffuse texture of clothing. Used for changing Color1 in the game.
    -   `tex-mask`: The name of the colormask texture of clothing. Used for changing Color1 in the game.
    -   `tex-main2`: The name of the diffuse texture of clothing. Used for changing Color2 in the game.
    -   `tex-mask2`: The name of the colormask texture of clothing. Used for changing Color2 in the game.
    -   `hide-bottom`: Whether the item is disabling rendering the bottom or not.

### Female Gloves

```xml
<list type="fgloves">
 <item
    id="" manifest="" kind="" possess="" en_us="" thumb-bundle="" thumb=""
    state="" mesh-bundle="" mesh-a="" tex-bundle="" tex-main=""
    tex-mask="" tex-main2="" tex-mask2=""
  />
</list>
```

-   Key Name: `fgloves`
-   Description: Female Gloves
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `state`:
        -   `0`: This item doesn't have half-off state.
        -   `1`: This item has half-off state.
    -   `mesh-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `mesh-a`: The name of the clothing prefab
    -   `tex-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `tex-main`: The name of the diffuse texture of clothing. Used for changing Color1 in the game.
    -   `tex-mask`: The name of the colormask texture of clothing. Used for changing Color1 in the game.
    -   `tex-main2`: The name of the diffuse texture of clothing. Used for changing Color2 in the game.
    -   `tex-mask2`: The name of the colormask texture of clothing. Used for changing Color2 in the game.

### Female Pantyhose

```xml
<list type="fpanst">
 <item
    id="" manifest="" kind="" possess="" en_us="" thumb-bundle="" thumb=""
    state="" mesh-bundle="" mesh-a="" tex-bundle="" tex-main=""
    tex-mask="" tex-main2="" tex-mask2=""
  />
</list>
```

-   Key Name: `fpanst`
-   Description: Female Pantystocking
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `state`:
        -   `0`: This item doesn't have half-off state.
        -   `1`: This item has half-off state.
    -   `mesh-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `mesh-a`: The name of the clothing prefab
    -   `tex-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `tex-main`: The name of the diffuse texture of clothing. Used for changing Color1 in the game.
    -   `tex-mask`: The name of the colormask texture of clothing. Used for changing Color1 in the game.
    -   `tex-main2`: The name of the diffuse texture of clothing. Used for changing Color2 in the game.
    -   `tex-mask2`: The name of the colormask texture of clothing. Used for changing Color2 in the game.
    -   `hide-bottom`: Whether the item is disabling rendering the bottom or not.

### Female Socks

```xml
<list type="fsocks">
 <item
    id="" manifest="" kind="" possess="" en_us="" thumb-bundle="" thumb=""
    state="" mesh-bundle="" mesh-a="" tex-bundle="" tex-main=""
    tex-mask="" tex-main2="" tex-mask2=""
  />
</list>
```

-   Key Name: `fsocks`
-   Description: Female Socks
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `state`:
        -   `0`: This item doesn't have half-off state.
        -   `1`: This item has half-off state.
    -   `mesh-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `mesh-a`: The name of the clothing prefab
    -   `tex-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `tex-main`: The name of the diffuse texture of clothing. Used for changing Color1 in the game.
    -   `tex-mask`: The name of the colormask texture of clothing. Used for changing Color1 in the game.
    -   `tex-main2`: The name of the diffuse texture of clothing. Used for changing Color2 in the game.
    -   `tex-mask2`: The name of the colormask texture of clothing. Used for changing Color2 in the game.

### Female Shoes

```xml
<list type="fshoes">
 <item
    id="" manifest="" kind="" possess="" en_us="" thumb-bundle="" thumb=""
    state="" mesh-bundle="" mesh-a="" tex-bundle="" tex-main=""
    tex-mask="" tex-main2="" tex-mask2=""
  />
</list>
```

-   Key Name: `fshoes`
-   Description: Female Shoes
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `state`:
        -   `0`: This item doesn't have half-off state.
        -   `1`: This item has half-off state.
    -   `mesh-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `mesh-a`: The name of the clothing prefab
    -   `tex-bundle`: The bundle path for the clothing prefab. The resolver will automatically resolve this path. Manually set this value when something went wrong.
    -   `tex-main`: The name of the diffuse texture of clothing. Used for changing Color1 in the game.
    -   `tex-mask`: The name of the colormask texture of clothing. Used for changing Color1 in the game.
    -   `tex-main2`: The name of the diffuse texture of clothing. Used for changing Color2 in the game.
    -   `tex-mask2`: The name of the colormask texture of clothing. Used for changing Color2 in the game.

### Common Skin Paint

```xml
<list type="spaint">
  <item id="" manifest="" kind="" possess="" en_us=""
   thumb-bundle="" thumb="" tex-bundle="" tex-a="" tex-g=""/>
</list>
```

-   Key Name: `spaint`
-   Description: Skin Paint
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `tex-bundle`: The bundle path for the `tex-*` assets.
    -   `tex-a`: The diffuse texture.
    -   `tex-g`: The gloss texture.

### Common Eyebrows

```xml
<list type="seyebrow">
  <item id="" manifest="" kind="" possess="" en_us=""
   thumb-bundle="" thumb="" tex-bundle="" tex-a="" />
</list>
```

-   Key Name: `seyebrow`
-   Description: Eyebrows
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `tex-bundle`: The bundle path for the `tex-*` assets.
    -   `tex-a`: The diffuse texture.

### Common Eyelash

```xml
<list type="seyelash">
  <item id="" manifest="" kind="" possess="" en_us=""
   thumb-bundle="" thumb="" tex-bundle="" tex-a="" />
</list>
```

-   Key Name: `seyelash`
-   Description: Eyelashes
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `tex-bundle`: The bundle path for the `tex-*` assets.
    -   `tex-a`: The diffuse texture.

### Common Eyeshadow

```xml
<list type="seyeshadow">
  <item id="" manifest="" kind="" possess="" en_us=""
   thumb-bundle="" thumb="" tex-bundle="" tex-a="" tex-g=""/>
</list>
```

-   Key Name: `seyeshadow`
-   Description: Eyeshadows
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `tex-bundle`: The bundle path for the `tex-*` assets.
    -   `tex-a`: The diffuse texture.
    -   `tex-g`: The gloss texture.

### Common Eye

```xml
<list type="seye">
  <item id="" manifest="" kind="" possess="" en_us=""
   thumb-bundle="" thumb="" tex-bundle="" tex-a="" />
</list>
```

-   Key Name: `seye`
-   Description: Eye Texture
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `tex-bundle`: The bundle path for the `tex-*` assets.
    -   `tex-a`: The diffuse texture.

### Common Eye Black

```xml
<list type="seyeblack">
  <item id="" manifest="" kind="" possess="" en_us=""
   thumb-bundle="" thumb="" tex-bundle="" tex-a="" />
</list>
```

-   Key Name: `seyeblack`
-   Description: Eyeblack Texture
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `tex-bundle`: The bundle path for the `tex-*` assets.
    -   `tex-a`: The diffuse texture.

### Common Eye Highlights

```xml
<list type="seye_hl">
  <item id="" manifest="" kind="" possess="" en_us=""
   thumb-bundle="" thumb="" tex-bundle="" tex-a="" />
</list>
```

-   Key Name: `seye_hl`
-   Description: Eyehighlights
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `tex-bundle`: The bundle path for the `tex-*` assets.
    -   `tex-a`: The diffuse texture.

### Common Cheek Red

```xml
<list type="scheek">
  <item id="" manifest="" kind="" possess="" en_us=""
   thumb-bundle="" thumb="" tex-bundle="" tex-a="" tex-g=""/>
</list>
```

-   Key Name: `scheek`
-   Description: Cheek Texture
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `tex-bundle`: The bundle path for the `tex-*` assets.
    -   `tex-a`: The diffuse texture.
    -   `tex-g`: The gloss texture.

### Common Lip Tint

```xml
<list type="slip">
  <item id="" manifest="" kind="" possess="" en_us=""
   thumb-bundle="" thumb="" tex-bundle="" tex-a="" tex-g=""/>
</list>
```

-   Key Name: `slip`
-   Description: Lip Texture
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `tex-bundle`: The bundle path for the `tex-*` assets.
    -   `tex-a`: The diffuse texture.
    -   `tex-g`: The gloss texture.

### Common Mole

```xml
<list type="smole">
  <item id="" manifest="" kind="" possess="" en_us=""
   thumb-bundle="" thumb="" tex-bundle="" tex-a="" tex-g=""/>
</list>
```

-   Key Name: `smole`
-   Description: Mole Texture
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `tex-bundle`: The bundle path for the `tex-*` assets.
    -   `tex-a`: The diffuse texture.
    -   `tex-g`: The gloss texture.

### Common Nipple

```xml
<list type="snip">
  <item id="" manifest="" kind="" possess="" en_us=""
   thumb-bundle="" thumb="" tex-bundle="" tex-a="" />
</list>
```

-   Key Name: `snip`
-   Description: Breast Tip Texture
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `tex-bundle`: The bundle path for the `tex-*` assets.
    -   `tex-a`: The diffuse texture.

### Common Underhair

```xml
<list type="sunderhair">
  <item id="" manifest="" kind="" possess="" en_us=""
   thumb-bundle="" thumb="" tex-bundle="" tex-a="" />
</list>
```

-   Key Name: `sunderhair`
-   Description: Underhair Texture
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `tex-bundle`: The bundle path for the `tex-*` assets.
    -   `tex-a`: The diffuse texture.

### Outfit Pattern

```xml
<list type="spattern">
  <item id="" manifest="" kind="" possess="" en_us=""
   thumb-bundle="" thumb="" tex-bundle="" tex-a="" />
</list>
```

-   Key Name: `spattern`
-   Description: Clothing/COlor Patterns
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `tex-bundle`: The bundle path for the `tex-*` assets.
    -   `tex-a`: The diffuse texture.

### Accessroy Slot: None

```xml
<list type="accnone">
  <item
    id="" manifest="" kind="" possess="" en_us=""
    thumb-bundle="" thumb="" mesh-a="" mesh-bundle="" parent=""
  />
</list>
```

-   Key Name: `accnone`
-   Description: Accessory None Slot
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `mesh-a`: The name of the accessory prefab asset.
    -   `mesh-bundle`: Then bundle path for the accessory prefab asset.
    -   `parent`: the parent gameobject of the accessory. This value can only contain one of this value.
        ```
            N_Hair_pony, N_Hair_twin_L, N_Hair_twin_R, N_Hair_pin_L, N_Hair_pin_R,
            N_Head_top, N_Hitai, N_Head, N_Face,
            N_Earring_L, N_Earring_R, N_Megane, N_Nose, N_Mouth,
            N_Neck, N_Chest_f, N_Chest, N_Tikubi_L, N_Tikubi_R, N_Back,
            N_Back_L, N_Back_R, N_Waist, N_Waist_f, N_Waist_b, N_Waist_L, N_Waist_R,
            N_Leg_L, N_Knee_L, N_Ankle_L, N_Foot_L, N_Leg_R, N_Knee_R, N_Ankle_R,
            N_Foot_R, N_Shoulder_L, N_Elbo_L, N_Arm_L, N_Wrist_L, N_Shoulder_R, N_Elbo_R,
            N_Arm_R, N_Wrist_R, N_Hand_L, N_Index_L, N_Middle_L, N_Ring_L,
            N_Hand_R, N_Index_R, N_Middle_R, N_Ring_R, N_Dan, N_Kokan, N_Ana
        ```

### Accessory Slot: Head

```xml
<list type="acchead">
  <item
    id="" manifest="" kind="" possess="" en_us=""
    thumb-bundle="" thumb="" mesh-a="" mesh-bundle="" parent=""
  />
</list>
```

-   Key Name: `acchead`
-   Description: Accessory Head Slot
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `mesh-a`: The name of the accessory prefab asset.
    -   `mesh-bundle`: Then bundle path for the accessory prefab asset.
    -   `parent`: the parent gameobject of the accessory. This value can only contain one of this value.
        ```
            N_Hair_pony, N_Hair_twin_L, N_Hair_twin_R, N_Hair_pin_L, N_Hair_pin_R,
            N_Head_top, N_Hitai, N_Head, N_Face,
            N_Earring_L, N_Earring_R, N_Megane, N_Nose, N_Mouth,
            N_Neck, N_Chest_f, N_Chest, N_Tikubi_L, N_Tikubi_R, N_Back,
            N_Back_L, N_Back_R, N_Waist, N_Waist_f, N_Waist_b, N_Waist_L, N_Waist_R,
            N_Leg_L, N_Knee_L, N_Ankle_L, N_Foot_L, N_Leg_R, N_Knee_R, N_Ankle_R,
            N_Foot_R, N_Shoulder_L, N_Elbo_L, N_Arm_L, N_Wrist_L, N_Shoulder_R, N_Elbo_R,
            N_Arm_R, N_Wrist_R, N_Hand_L, N_Index_L, N_Middle_L, N_Ring_L,
            N_Hand_R, N_Index_R, N_Middle_R, N_Ring_R, N_Dan, N_Kokan, N_Ana
        ```

### Accessory Slot: Ears

```xml
<list type="accear">
  <item
    id="" manifest="" kind="" possess="" en_us=""
    thumb-bundle="" thumb="" mesh-a="" mesh-bundle="" parent=""
  />
</list>
```

-   Key Name: `accear`
-   Description: Accessory Ear Slot
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `mesh-a`: The name of the accessory prefab asset.
    -   `mesh-bundle`: Then bundle path for the accessory prefab asset.
    -   `parent`: the parent gameobject of the accessory. This value can only contain one of this value.
        ```
            N_Hair_pony, N_Hair_twin_L, N_Hair_twin_R, N_Hair_pin_L, N_Hair_pin_R,
            N_Head_top, N_Hitai, N_Head, N_Face,
            N_Earring_L, N_Earring_R, N_Megane, N_Nose, N_Mouth,
            N_Neck, N_Chest_f, N_Chest, N_Tikubi_L, N_Tikubi_R, N_Back,
            N_Back_L, N_Back_R, N_Waist, N_Waist_f, N_Waist_b, N_Waist_L, N_Waist_R,
            N_Leg_L, N_Knee_L, N_Ankle_L, N_Foot_L, N_Leg_R, N_Knee_R, N_Ankle_R,
            N_Foot_R, N_Shoulder_L, N_Elbo_L, N_Arm_L, N_Wrist_L, N_Shoulder_R, N_Elbo_R,
            N_Arm_R, N_Wrist_R, N_Hand_L, N_Index_L, N_Middle_L, N_Ring_L,
            N_Hand_R, N_Index_R, N_Middle_R, N_Ring_R, N_Dan, N_Kokan, N_Ana
        ```

### Accessory Slot: Glasses

```xml
<list type="accglasses">
  <item
    id="" manifest="" kind="" possess="" en_us=""
    thumb-bundle="" thumb="" mesh-a="" mesh-bundle="" parent=""
  />
</list>
```

-   Key Name: `accglasses`
-   Description: Accessory Glasses Slot
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `mesh-a`: The name of the accessory prefab asset.
    -   `mesh-bundle`: Then bundle path for the accessory prefab asset.
    -   `parent`: the parent gameobject of the accessory. This value can only contain one of this value.
        ```
            N_Hair_pony, N_Hair_twin_L, N_Hair_twin_R, N_Hair_pin_L, N_Hair_pin_R,
            N_Head_top, N_Hitai, N_Head, N_Face,
            N_Earring_L, N_Earring_R, N_Megane, N_Nose, N_Mouth,
            N_Neck, N_Chest_f, N_Chest, N_Tikubi_L, N_Tikubi_R, N_Back,
            N_Back_L, N_Back_R, N_Waist, N_Waist_f, N_Waist_b, N_Waist_L, N_Waist_R,
            N_Leg_L, N_Knee_L, N_Ankle_L, N_Foot_L, N_Leg_R, N_Knee_R, N_Ankle_R,
            N_Foot_R, N_Shoulder_L, N_Elbo_L, N_Arm_L, N_Wrist_L, N_Shoulder_R, N_Elbo_R,
            N_Arm_R, N_Wrist_R, N_Hand_L, N_Index_L, N_Middle_L, N_Ring_L,
            N_Hand_R, N_Index_R, N_Middle_R, N_Ring_R, N_Dan, N_Kokan, N_Ana
        ```

### Accessory Slot: Face

```xml
<list type="accface">
  <item
    id="" manifest="" kind="" possess="" en_us=""
    thumb-bundle="" thumb="" mesh-a="" mesh-bundle="" parent=""
  />
</list>
```

-   Key Name: `accface`
-   Description: Accessory Face Slot
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `mesh-a`: The name of the accessory prefab asset.
    -   `mesh-bundle`: Then bundle path for the accessory prefab asset.
    -   `parent`: the parent gameobject of the accessory. This value can only contain one of this value.
        ```
            N_Hair_pony, N_Hair_twin_L, N_Hair_twin_R, N_Hair_pin_L, N_Hair_pin_R,
            N_Head_top, N_Hitai, N_Head, N_Face,
            N_Earring_L, N_Earring_R, N_Megane, N_Nose, N_Mouth,
            N_Neck, N_Chest_f, N_Chest, N_Tikubi_L, N_Tikubi_R, N_Back,
            N_Back_L, N_Back_R, N_Waist, N_Waist_f, N_Waist_b, N_Waist_L, N_Waist_R,
            N_Leg_L, N_Knee_L, N_Ankle_L, N_Foot_L, N_Leg_R, N_Knee_R, N_Ankle_R,
            N_Foot_R, N_Shoulder_L, N_Elbo_L, N_Arm_L, N_Wrist_L, N_Shoulder_R, N_Elbo_R,
            N_Arm_R, N_Wrist_R, N_Hand_L, N_Index_L, N_Middle_L, N_Ring_L,
            N_Hand_R, N_Index_R, N_Middle_R, N_Ring_R, N_Dan, N_Kokan, N_Ana
        ```

### Accessory Slot: Neck

```xml
<list type="accneck">
  <item
    id="" manifest="" kind="" possess="" en_us=""
    thumb-bundle="" thumb="" mesh-a="" mesh-bundle="" parent=""
  />
</list>
```

-   Key Name: `accneck`
-   Description: Accessory Neck Slot
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `mesh-a`: The name of the accessory prefab asset.
    -   `mesh-bundle`: Then bundle path for the accessory prefab asset.
    -   `parent`: the parent gameobject of the accessory. This value can only contain one of this value.
        ```
            N_Hair_pony, N_Hair_twin_L, N_Hair_twin_R, N_Hair_pin_L, N_Hair_pin_R,
            N_Head_top, N_Hitai, N_Head, N_Face,
            N_Earring_L, N_Earring_R, N_Megane, N_Nose, N_Mouth,
            N_Neck, N_Chest_f, N_Chest, N_Tikubi_L, N_Tikubi_R, N_Back,
            N_Back_L, N_Back_R, N_Waist, N_Waist_f, N_Waist_b, N_Waist_L, N_Waist_R,
            N_Leg_L, N_Knee_L, N_Ankle_L, N_Foot_L, N_Leg_R, N_Knee_R, N_Ankle_R,
            N_Foot_R, N_Shoulder_L, N_Elbo_L, N_Arm_L, N_Wrist_L, N_Shoulder_R, N_Elbo_R,
            N_Arm_R, N_Wrist_R, N_Hand_L, N_Index_L, N_Middle_L, N_Ring_L,
            N_Hand_R, N_Index_R, N_Middle_R, N_Ring_R, N_Dan, N_Kokan, N_Ana
        ```

### Accessory Slot: Shoulder

```xml
<list type="accshoulder">
  <item
    id="" manifest="" kind="" possess="" en_us=""
    thumb-bundle="" thumb="" mesh-a="" mesh-bundle="" parent=""
  />
</list>
```

-   Key Name: `accshoulder`
-   Description: Accessory Shoulder Slot
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `mesh-a`: The name of the accessory prefab asset.
    -   `mesh-bundle`: Then bundle path for the accessory prefab asset.
    -   `parent`: the parent gameobject of the accessory. This value can only contain one of this value.
        ```
            N_Hair_pony, N_Hair_twin_L, N_Hair_twin_R, N_Hair_pin_L, N_Hair_pin_R,
            N_Head_top, N_Hitai, N_Head, N_Face,
            N_Earring_L, N_Earring_R, N_Megane, N_Nose, N_Mouth,
            N_Neck, N_Chest_f, N_Chest, N_Tikubi_L, N_Tikubi_R, N_Back,
            N_Back_L, N_Back_R, N_Waist, N_Waist_f, N_Waist_b, N_Waist_L, N_Waist_R,
            N_Leg_L, N_Knee_L, N_Ankle_L, N_Foot_L, N_Leg_R, N_Knee_R, N_Ankle_R,
            N_Foot_R, N_Shoulder_L, N_Elbo_L, N_Arm_L, N_Wrist_L, N_Shoulder_R, N_Elbo_R,
            N_Arm_R, N_Wrist_R, N_Hand_L, N_Index_L, N_Middle_L, N_Ring_L,
            N_Hand_R, N_Index_R, N_Middle_R, N_Ring_R, N_Dan, N_Kokan, N_Ana
        ```

### Accessory Slot: Chest

```xml
<list type="accchest">
  <item
    id="" manifest="" kind="" possess="" en_us=""
    thumb-bundle="" thumb="" mesh-a="" mesh-bundle="" parent=""
  />
</list>
```

-   Key Name: `accchest`
-   Description: Accessory Chest Slot
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `mesh-a`: The name of the accessory prefab asset.
    -   `mesh-bundle`: Then bundle path for the accessory prefab asset.
    -   `parent`: the parent gameobject of the accessory. This value can only contain one of this value.
        ```
            N_Hair_pony, N_Hair_twin_L, N_Hair_twin_R, N_Hair_pin_L, N_Hair_pin_R,
            N_Head_top, N_Hitai, N_Head, N_Face,
            N_Earring_L, N_Earring_R, N_Megane, N_Nose, N_Mouth,
            N_Neck, N_Chest_f, N_Chest, N_Tikubi_L, N_Tikubi_R, N_Back,
            N_Back_L, N_Back_R, N_Waist, N_Waist_f, N_Waist_b, N_Waist_L, N_Waist_R,
            N_Leg_L, N_Knee_L, N_Ankle_L, N_Foot_L, N_Leg_R, N_Knee_R, N_Ankle_R,
            N_Foot_R, N_Shoulder_L, N_Elbo_L, N_Arm_L, N_Wrist_L, N_Shoulder_R, N_Elbo_R,
            N_Arm_R, N_Wrist_R, N_Hand_L, N_Index_L, N_Middle_L, N_Ring_L,
            N_Hand_R, N_Index_R, N_Middle_R, N_Ring_R, N_Dan, N_Kokan, N_Ana
        ```

### Accessory Slot: Waist

```xml
<list type="accwaist">
  <item
    id="" manifest="" kind="" possess="" en_us=""
    thumb-bundle="" thumb="" mesh-a="" mesh-bundle="" parent=""
  />
</list>
```

-   Key Name: `accwaist`
-   Description: Accessory Waist Slot
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `mesh-a`: The name of the accessory prefab asset.
    -   `mesh-bundle`: Then bundle path for the accessory prefab asset.
    -   `parent`: the parent gameobject of the accessory. This value can only contain one of this value.
        ```
            N_Hair_pony, N_Hair_twin_L, N_Hair_twin_R, N_Hair_pin_L, N_Hair_pin_R,
            N_Head_top, N_Hitai, N_Head, N_Face,
            N_Earring_L, N_Earring_R, N_Megane, N_Nose, N_Mouth,
            N_Neck, N_Chest_f, N_Chest, N_Tikubi_L, N_Tikubi_R, N_Back,
            N_Back_L, N_Back_R, N_Waist, N_Waist_f, N_Waist_b, N_Waist_L, N_Waist_R,
            N_Leg_L, N_Knee_L, N_Ankle_L, N_Foot_L, N_Leg_R, N_Knee_R, N_Ankle_R,
            N_Foot_R, N_Shoulder_L, N_Elbo_L, N_Arm_L, N_Wrist_L, N_Shoulder_R, N_Elbo_R,
            N_Arm_R, N_Wrist_R, N_Hand_L, N_Index_L, N_Middle_L, N_Ring_L,
            N_Hand_R, N_Index_R, N_Middle_R, N_Ring_R, N_Dan, N_Kokan, N_Ana
        ```

### Accessory Slot: Back

```xml
<list type="accback">
  <item
    id="" manifest="" kind="" possess="" en_us=""
    thumb-bundle="" thumb="" mesh-a="" mesh-bundle="" parent=""
  />
</list>
```

-   Key Name: `accback`
-   Description: Accessory Back Slot
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `mesh-a`: The name of the accessory prefab asset.
    -   `mesh-bundle`: Then bundle path for the accessory prefab asset.
    -   `parent`: the parent gameobject of the accessory. This value can only contain one of this value.
        ```
            N_Hair_pony, N_Hair_twin_L, N_Hair_twin_R, N_Hair_pin_L, N_Hair_pin_R,
            N_Head_top, N_Hitai, N_Head, N_Face,
            N_Earring_L, N_Earring_R, N_Megane, N_Nose, N_Mouth,
            N_Neck, N_Chest_f, N_Chest, N_Tikubi_L, N_Tikubi_R, N_Back,
            N_Back_L, N_Back_R, N_Waist, N_Waist_f, N_Waist_b, N_Waist_L, N_Waist_R,
            N_Leg_L, N_Knee_L, N_Ankle_L, N_Foot_L, N_Leg_R, N_Knee_R, N_Ankle_R,
            N_Foot_R, N_Shoulder_L, N_Elbo_L, N_Arm_L, N_Wrist_L, N_Shoulder_R, N_Elbo_R,
            N_Arm_R, N_Wrist_R, N_Hand_L, N_Index_L, N_Middle_L, N_Ring_L,
            N_Hand_R, N_Index_R, N_Middle_R, N_Ring_R, N_Dan, N_Kokan, N_Ana
        ```

### Accessory Slot: Arm

```xml
<list type="accarm">
  <item
    id="" manifest="" kind="" possess="" en_us=""
    thumb-bundle="" thumb="" mesh-a="" mesh-bundle="" parent=""
  />
</list>
```

-   Key Name: `accarm`
-   Description: Accessory Arm Slot
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `mesh-a`: The name of the accessory prefab asset.
    -   `mesh-bundle`: Then bundle path for the accessory prefab asset.
    -   `parent`: the parent gameobject of the accessory. This value can only contain one of this value.
        ```
            N_Hair_pony, N_Hair_twin_L, N_Hair_twin_R, N_Hair_pin_L, N_Hair_pin_R,
            N_Head_top, N_Hitai, N_Head, N_Face,
            N_Earring_L, N_Earring_R, N_Megane, N_Nose, N_Mouth,
            N_Neck, N_Chest_f, N_Chest, N_Tikubi_L, N_Tikubi_R, N_Back,
            N_Back_L, N_Back_R, N_Waist, N_Waist_f, N_Waist_b, N_Waist_L, N_Waist_R,
            N_Leg_L, N_Knee_L, N_Ankle_L, N_Foot_L, N_Leg_R, N_Knee_R, N_Ankle_R,
            N_Foot_R, N_Shoulder_L, N_Elbo_L, N_Arm_L, N_Wrist_L, N_Shoulder_R, N_Elbo_R,
            N_Arm_R, N_Wrist_R, N_Hand_L, N_Index_L, N_Middle_L, N_Ring_L,
            N_Hand_R, N_Index_R, N_Middle_R, N_Ring_R, N_Dan, N_Kokan, N_Ana
        ```

### Accessory Slot: Hand

```xml
<list type="acchand">
  <item
    id="" manifest="" kind="" possess="" en_us=""
    thumb-bundle="" thumb="" mesh-a="" mesh-bundle="" parent=""
  />
</list>
```

-   Key Name: `acchand`
-   Description: Accessory Hand Slot
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `mesh-a`: The name of the accessory prefab asset.
    -   `mesh-bundle`: Then bundle path for the accessory prefab asset.
    -   `parent`: the parent gameobject of the accessory. This value can only contain one of this value.
        ```
            N_Hair_pony, N_Hair_twin_L, N_Hair_twin_R, N_Hair_pin_L, N_Hair_pin_R,
            N_Head_top, N_Hitai, N_Head, N_Face,
            N_Earring_L, N_Earring_R, N_Megane, N_Nose, N_Mouth,
            N_Neck, N_Chest_f, N_Chest, N_Tikubi_L, N_Tikubi_R, N_Back,
            N_Back_L, N_Back_R, N_Waist, N_Waist_f, N_Waist_b, N_Waist_L, N_Waist_R,
            N_Leg_L, N_Knee_L, N_Ankle_L, N_Foot_L, N_Leg_R, N_Knee_R, N_Ankle_R,
            N_Foot_R, N_Shoulder_L, N_Elbo_L, N_Arm_L, N_Wrist_L, N_Shoulder_R, N_Elbo_R,
            N_Arm_R, N_Wrist_R, N_Hand_L, N_Index_L, N_Middle_L, N_Ring_L,
            N_Hand_R, N_Index_R, N_Middle_R, N_Ring_R, N_Dan, N_Kokan, N_Ana
        ```

### Accessory Slot: Leg

```xml
<list type="accleg">
  <item
    id="" manifest="" kind="" possess="" en_us=""
    thumb-bundle="" thumb="" mesh-a="" mesh-bundle="" parent=""
  />
</list>
```

-   Key Name: `accleg`
-   Description: Accessory Leg Slot
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `mesh-a`: The name of the accessory prefab asset.
    -   `mesh-bundle`: Then bundle path for the accessory prefab asset.
    -   `parent`: the parent gameobject of the accessory. This value can only contain one of this value.
        ```
            N_Hair_pony, N_Hair_twin_L, N_Hair_twin_R, N_Hair_pin_L, N_Hair_pin_R,
            N_Head_top, N_Hitai, N_Head, N_Face,
            N_Earring_L, N_Earring_R, N_Megane, N_Nose, N_Mouth,
            N_Neck, N_Chest_f, N_Chest, N_Tikubi_L, N_Tikubi_R, N_Back,
            N_Back_L, N_Back_R, N_Waist, N_Waist_f, N_Waist_b, N_Waist_L, N_Waist_R,
            N_Leg_L, N_Knee_L, N_Ankle_L, N_Foot_L, N_Leg_R, N_Knee_R, N_Ankle_R,
            N_Foot_R, N_Shoulder_L, N_Elbo_L, N_Arm_L, N_Wrist_L, N_Shoulder_R, N_Elbo_R,
            N_Arm_R, N_Wrist_R, N_Hand_L, N_Index_L, N_Middle_L, N_Ring_L,
            N_Hand_R, N_Index_R, N_Middle_R, N_Ring_R, N_Dan, N_Kokan, N_Ana
        ```

### Accessory Slot: Pubic Area

```xml
<list type="acckokan">
  <item
    id="" manifest="" kind="" possess="" en_us=""
    thumb-bundle="" thumb="" mesh-a="" mesh-bundle="" parent=""
  />
</list>
```

-   Key Name: `acckokan`
-   Description: Accessory Kokan Slot
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `mesh-a`: The name of the accessory prefab asset.
    -   `mesh-bundle`: Then bundle path for the accessory prefab asset.
    -   `parent`: the parent gameobject of the accessory. This value can only contain one of this value.
        ```
            N_Hair_pony, N_Hair_twin_L, N_Hair_twin_R, N_Hair_pin_L, N_Hair_pin_R,
            N_Head_top, N_Hitai, N_Head, N_Face,
            N_Earring_L, N_Earring_R, N_Megane, N_Nose, N_Mouth,
            N_Neck, N_Chest_f, N_Chest, N_Tikubi_L, N_Tikubi_R, N_Back,
            N_Back_L, N_Back_R, N_Waist, N_Waist_f, N_Waist_b, N_Waist_L, N_Waist_R,
            N_Leg_L, N_Knee_L, N_Ankle_L, N_Foot_L, N_Leg_R, N_Knee_R, N_Ankle_R,
            N_Foot_R, N_Shoulder_L, N_Elbo_L, N_Arm_L, N_Wrist_L, N_Shoulder_R, N_Elbo_R,
            N_Arm_R, N_Wrist_R, N_Hand_L, N_Index_L, N_Middle_L, N_Ring_L,
            N_Hand_R, N_Index_R, N_Middle_R, N_Ring_R, N_Dan, N_Kokan, N_Ana
        ```

### Hair Back Slot

```xml
<list type="hairback">
  <item
    id="" manifest="" kind="" possess="" en_us="" thumb-bundle=""
    thumb="" mesh-a="" mesh-b="" mesh-bundle="" weights=""
    ringoff="" tex-manifest="" tex-a="" tex-b="" tex-bundle=""
    set-hair=""
  />
</list>
```

-   Key Name: `hairback`
-   Description: Back Hair Slot
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `mesh-a`: The name of the hair prefab asset
    -   `mesh-b`: The name of the accessory prefab asset
    -   `mesh-bundle`: The assetbundle path for the all prefab asset
    -   `weights`: The weight copy target.
        -   `0`: Does nothing
        -   `1`: Copy weights from the `cf_J_Root`
        -   `2`: Copy weights from the `cf_J_FaceRoot`
    -   `ringoff`: The value of the hair material's property `_Ringoff`. can be `1` or `0`.
    -   `tex-manifest`:
    -   `tex-a`: The name of the diffuse color texture of the hair
    -   `tex-b`: The name of the colormask texture of the hair
    -   `tex-bundle`: The assetbundle path for the all texture asset
    -   `set-hair`: This value is not referenced in anywhere in the game's codebase.

### Hair Front Slot

```xml
<list type="hairfront">
  <item
    id="" manifest="" kind="" possess="" en_us="" thumb-bundle=""
    thumb="" mesh-a="" mesh-b="" mesh-bundle="" weights=""
    ringoff="" tex-manifest="" tex-a="" tex-b="" tex-bundle=""
    set-hair=""
  />
</list>
```

-   Key Name: `hairfront`
-   Description: Front Hair Slot
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `mesh-a`: The name of the hair prefab asset
    -   `mesh-b`: The name of the accessory prefab asset
    -   `mesh-bundle`: The assetbundle path for the all prefab asset
    -   `weights`: The weight copy target.
        -   `0`: Does nothing
        -   `1`: Copy weights from the `cf_J_Root`
        -   `2`: Copy weights from the `cf_J_FaceRoot`
    -   `ringoff`: The value of the hair material's property `_Ringoff`. can be `1` or `0`.
    -   `tex-manifest`:
    -   `tex-a`: The name of the diffuse color texture of the hair
    -   `tex-b`: The name of the colormask texture of the hair
    -   `tex-bundle`: The assetbundle path for the all texture asset
    -   `set-hair`: This value is not referenced in anywhere in the game's codebase.

### Hair Side Slot

```xml
<list type="hairside">
  <item
    id="" manifest="" kind="" possess="" en_us="" thumb-bundle=""
    thumb="" mesh-a="" mesh-b="" mesh-bundle="" weights=""
    ringoff="" tex-manifest="" tex-a="" tex-b="" tex-bundle=""
    set-hair=""
  />
</list>
```

-   Key Name: `hairside`
-   Description: Side Hair Slot
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `mesh-a`: The name of the hair prefab asset
    -   `mesh-b`: The name of the accessory prefab asset
    -   `mesh-bundle`: The assetbundle path for the all prefab asset
    -   `weights`: The weight copy target.
        -   `0`: Does nothing
        -   `1`: Copy weights from the `cf_J_Root`
        -   `2`: Copy weights from the `cf_J_FaceRoot`
    -   `ringoff`: The value of the hair material's property `_Ringoff`. can be `1` or `0`.
    -   `tex-manifest`:
    -   `tex-a`: The name of the diffuse color texture of the hair
    -   `tex-b`: The name of the colormask texture of the hair
    -   `tex-bundle`: The assetbundle path for the all texture asset
    -   `set-hair`: This value is not referenced in anywhere in the game's codebase.

### Hair Extension Slot

```xml
<list type="hairext">
  <item
    id="" manifest="" kind="" possess="" en_us="" thumb-bundle=""
    thumb="" mesh-a="" mesh-b="" mesh-bundle="" weights=""
    ringoff="" tex-manifest="" tex-a="" tex-b="" tex-bundle=""
    set-hair=""
  />
</list>
```

-   Key Name: `hairext`
-   Description: Hair Extension Slot
-   Key List

    -   `id`: The id of the item. The modding tool mostly automatically resolve the id. Set the `id` manually when the mod update requires legacy id support.
    -   `manifest`: Manifest Bundle name of the item. The modding tool mostly automatically resolve the mainfest value.
    -   `kind`: Unused in the code. Nothing is calling `ChaControl.GetNowClothesType` nor `ChaInfo.GetHairType`.
    -   `possess`:
        -   `0`: Do Nothing
        -   `1`: Mark as "Init" Mod
        -   `2`: Mark as "New" Mod
        -   `99`: Hide from the character creation but make it loadable
    -   `en_us`: A name for english client.
    -   `thumb-bundle`: The bundle path for the thumbnail asset.
    -   `thumb`: The name of the thumbnail asset.
    -   `mesh-a`: The name of the hair prefab asset
    -   `mesh-b`: The name of the accessory prefab asset
    -   `mesh-bundle`: The assetbundle path for the all prefab asset
    -   `weights`: The weight copy target.
        -   `0`: Does nothing
        -   `1`: Copy weights from the `cf_J_Root`
        -   `2`: Copy weights from the `cf_J_FaceRoot`
    -   `ringoff`: The value of the hair material's property `_Ringoff`. can be `1` or `0`.
    -   `tex-manifest`:
    -   `tex-a`: The name of the diffuse color texture of the hair
    -   `tex-b`: The name of the colormask texture of the hair
    -   `tex-bundle`: The assetbundle path for the all texture asset
    -   `set-hair`: This value is not referenced in anywhere in the game's codebase.
