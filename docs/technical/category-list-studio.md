# ALL Possible Studio Item List Types

?> Most of them work, there might be edge case that I couldn't tested. Since the Document is really long, I suggest you to search around with Ctrl+F key.

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
