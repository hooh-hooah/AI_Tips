# ALL Possbiel XML List Types

?> Most of them work, there might be edge case that I couldn't tested.

## All Possible Studio Category List

### Big Category

```xml
<list type="bigcategory">
  <item id="number" name="category name">
</list>
```

-   Key Name: `bigcategory`
-   Description: Character Category Slot
-   Key List

    -   `id`: id of Big Category

        must be unique to all game

    -   `name`: The name of Big Category

### Mid Category

```xml
<list type="midcategory">
  <item big-category="number" id="number" name="category name">
</list>
```

-   Key Name: `midcategory`
-   Description: Character Category Slot
-   Key List

    -   `id`: id of Mid Category

        must be unique to all game

    -   `big-category`: id of Big Category

    -   `name`: The name of Mid Category

### Studio Item

```xml
<list type="props">
  <item big-category="number" mid-category="number" name="name" object="prefab's name">
</list>
```

-   Key Name: `studioitem` or `props`
-   Description: Character Category Slot
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
<list type="mhead">
  <item key="value">
</list>
```

-   Key Name: `mhead`
-   Description: Character Category Slot
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
-   Description: Character Category Slot
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
-   Description: Character Category Slot
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
-   Description: Character Category Slot
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
  <item key="value">
</list>
```

-   Key Name: `mhead`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Male Face Skin

```xml
<list type="mskinf">
  <item key="value">
</list>
```

-   Key Name: `mskinf`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Male Face Detail

```xml
<list type="mdetailf">
  <item key="value">
</list>
```

-   Key Name: `mdetailf`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Male Beard Texture

```xml
<list type="mbeard">
  <item key="value">
</list>
```

-   Key Name: `mbeard`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Male Body Skin

```xml
<list type="mskinb">
  <item key="value">
</list>
```

-   Key Name: `mskinb`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Male Body Detail

```xml
<list type="mdetailb">
  <item key="value">
</list>
```

-   Key Name: `mdetailb`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Male Sunburn

```xml
<list type="msunburn">
  <item key="value">
</list>
```

-   Key Name: `msunburn`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Male Top

```xml
<list type="mtop">
  <item key="value">
</list>
```

-   Key Name: `mtop`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Male Bottom

```xml
<list type="mbottom">
  <item key="value">
</list>
```

-   Key Name: `mbottom`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Male Gloves

```xml
<list type="mgloves">
  <item key="value">
</list>
```

-   Key Name: `mgloves`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Male Shoes

```xml
<list type="mshoes">
  <item key="value">
</list>
```

-   Key Name: `mshoes`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Female Head

```xml
<list type="fhead">
  <item key="value">
</list>
```

-   Key Name: `fhead`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Female Face Skin

```xml
<list type="fskinf">
  <item key="value">
</list>
```

-   Key Name: `fskinf`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Female Face Detail

```xml
<list type="fdetailf">
  <item key="value">
</list>
```

-   Key Name: `fdetailf`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Female Body Skin

```xml
<list type="fskinb">
  <item key="value">
</list>
```

-   Key Name: `fskinb`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Female Body Detail

```xml
<list type="fdetailb">
  <item key="value">
</list>
```

-   Key Name: `fdetailb`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Female Sun Burn

```xml
<list type="fsunburn">
  <item key="value">
</list>
```

-   Key Name: `fsunburn`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Female Top

```xml
<list type="ftop">
  <item key="value">
</list>
```

-   Key Name: `ftop`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Female Bottom Clothing

```xml
<list type="fbottom">
  <item key="value">
</list>
```

-   Key Name: `fbottom`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Female Inner Top

```xml
<list type="fintop">
  <item key="value">
</list>
```

-   Key Name: `fintop`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Female Inner Bottom

```xml
<list type="finbottom">
  <item key="value">
</list>
```

-   Key Name: `finbottom`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Female Gloves

```xml
<list type="fgloves">
  <item key="value">
</list>
```

-   Key Name: `fgloves`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Female Pantyhose

```xml
<list type="fpanst">
  <item key="value">
</list>
```

-   Key Name: `fpanst`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Female Socks

```xml
<list type="fsocks">
  <item key="value">
</list>
```

-   Key Name: `fsocks`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Female Shoes

```xml
<list type="fshoes">
  <item key="value">
</list>
```

-   Key Name: `fshoes`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Common Skin Paint

```xml
<list type="spaint">
  <item key="value">
</list>
```

-   Key Name: `spaint`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Common Eyebrows

```xml
<list type="seyebrow">
  <item key="value">
</list>
```

-   Key Name: `seyebrow`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Common Eyelash

```xml
<list type="seyelash">
  <item key="value">
</list>
```

-   Key Name: `seyelash`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Common Eyeshadow

```xml
<list type="seyeshadow">
  <item key="value">
</list>
```

-   Key Name: `seyeshadow`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Common Eye

```xml
<list type="seye">
  <item key="value">
</list>
```

-   Key Name: `seye`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Common Eye Black

```xml
<list type="seyeblack">
  <item key="value">
</list>
```

-   Key Name: `seyeblack`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Common Eye Highlights

```xml
<list type="seye_hl">
  <item key="value">
</list>
```

-   Key Name: `seye_hl`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Common Cheek Red

```xml
<list type="scheek">
  <item key="value">
</list>
```

-   Key Name: `scheek`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Common Lip Tint

```xml
<list type="slip">
  <item key="value">
</list>
```

-   Key Name: `slip`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Common Mole

```xml
<list type="smole">
  <item key="value">
</list>
```

-   Key Name: `smole`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Common Nipple

```xml
<list type="snip">
  <item key="value">
</list>
```

-   Key Name: `snip`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Common Underhair

```xml
<list type="sunderhair">
  <item key="value">
</list>
```

-   Key Name: `sunderhair`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Outfit Pattern

```xml
<list type="spattern">
  <item key="value">
</list>
```

-   Key Name: `spattern`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Accessroy Slot: None

```xml
<list type="accnone">
  <item key="value">
</list>
```

-   Key Name: `accnone`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Accessory Slot: Head

```xml
<list type="acchead">
  <item key="value">
</list>
```

-   Key Name: `acchead`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Accessory Slot: Ears

```xml
<list type="accear">
  <item key="value">
</list>
```

-   Key Name: `accear`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Accessory Slot: Glasses

```xml
<list type="accglasses">
  <item key="value">
</list>
```

-   Key Name: `accglasses`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Accessory Slot: Face

```xml
<list type="accface">
  <item key="value">
</list>
```

-   Key Name: `accface`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Accessory Slot: Neck

```xml
<list type="accneck">
  <item key="value">
</list>
```

-   Key Name: `accneck`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Accessory Slot: Shoulder

```xml
<list type="accshoulder">
  <item key="value">
</list>
```

-   Key Name: `accshoulder`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Accessory Slot: Chest

```xml
<list type="accchest">
  <item key="value">
</list>
```

-   Key Name: `accchest`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Accessory Slot: Waist

```xml
<list type="accwaist">
  <item key="value">
</list>
```

-   Key Name: `accwaist`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Accessory Slot: Back

```xml
<list type="accback">
  <item key="value">
</list>
```

-   Key Name: `accback`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Accessory Slot: Arm

```xml
<list type="accarm">
  <item key="value">
</list>
```

-   Key Name: `accarm`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Accessory Slot: Hand

```xml
<list type="acchand">
  <item key="value">
</list>
```

-   Key Name: `acchand`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Accessory Slot: Leg

```xml
<list type="accleg">
  <item key="value">
</list>
```

-   Key Name: `accleg`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Accessory Slot: Pubic Area

```xml
<list type="acckokan">
  <item key="value">
</list>
```

-   Key Name: `acckokan`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Hair Back Slot

```xml
<list type="hairback">
  <item key="value">
</list>
```

-   Key Name: `hairback`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Hair Front Slot

```xml
<list type="hairfront">
  <item key="value">
</list>
```

-   Key Name: `hairfront`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Hair Side Slot

```xml
<list type="hairside">
  <item key="value">
</list>
```

-   Key Name: `hairside`
-   Description: Character Category Slot
-   Key List
    -   `id`: description

### Hair Extension Slot

```xml
<list type="hairext">
  <item key="value">
</list>
```

-   Key Name: `hairext`
-   Description: Character Category Slot
-   Key List
    -   `id`: description
