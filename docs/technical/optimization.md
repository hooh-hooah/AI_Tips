# Optimization

## Game Performance Optimization

### Shadow is HEAVY.

If you're having bad performance on your map or studio item, check if your map/item has an excessive amount of lights with cast shadow enabled.

Rendering shadow is a really expensive operation, and they're not recommending people not to make all lights cast a dynamic shadow.

there are a few options that you can consider:

For studio items and maps: remove all lights completely.

-   For maps: change your map lights into static light, and bake the map. You can check the information about baking the light in this Document.
-   for maps/studio (paid option): get bakery asset and bake your map or studio as lightmap baked prefab.

There is no other way than pre-baking all of your light to avoid dynamic shadow fps drop.

### Occlusion Probes

for maps, sometimes your plan is too slow because the camera is rendering everything in your scene

you can reduce draw calls by implementing occlusion probes

it will kind of mess up out of bound shot in the studio

but it worth the try because it's going to save your fps

### Don't set anything "Real-time".

Most of the unity's real-time operation is not big, but if you set everything in real-time, The Unity Engine can't handle all real-time operations and cause a bad FPS rate.

Bake everything as you can.

### You don't need 4k Texture for the trashcan

texture optimization is one of the things you should consider to optimize your mod

-   512 to 1024 texture for most of the small background objects
-   1024 to 2048 for mid-sized Objects
-   2048 to 4096 for Clothing Textures

Consider the size and importance of your object. if your item tends to get spotlight often, then use a higher resolution texture

!> compressing normal map will cause weird rectangle lighting reflection artifacts. I suggest using a lower resolution normal map with no or less compression applied.

### Do not re-zip your mod

Yes. modding tool zip archive method does not compress anything in the zipmod making process

But this is all done for optimizing the loading time of the game.

If you have to optimize the size of your zipmod, please compress the zipmod itself and don't extract and compress it again.

### Use Dependency Loader when it's big

Dependency loader is one of the plugins I've made.
The Dependency Loader is for optimizing your mod's size and decreasing the loading time of the mod.

If you don't use a dependency loader, each asset bundle will save all the dependency on its Asset Bundle, and it will cause bloated bundle size and increased loading time.

Consider using the dependency loader when your zipmod is big, like map+studio item combo.

## Workflow Performance Optimization

The word optimization is not designed only for 'Game Performance'. Making the mod can be faster by automating your process.

You can automate a bit time-consuming tasks such as:

-   In-game Map/Studio/Clothing Thumbnail Generation
-   Applying changes to massive amount of files

### Make Templates

Make your template to start a new mod. it will reduce the time to make the mod

### Everyday Unity Time Saving: Peek

peek is a useful tool that adds many things
