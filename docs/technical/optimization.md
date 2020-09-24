# Optimization

## Game Performance Optimization

### Shadow is HEAVY.

If you're having bad performance on your map or studio item, check if your map/item has excessive amount of lights with cast shadow on. 

rendering shadow is really expensive operation and they're not recommending people to not make all lights cast dynamic shadow.

there is few options that you can consider:

 - for studio items and maps : remove all lights completely.
 
 - for maps: change your map lights into static light, and bake the map. baking process is explained in here.
 
 - for maps/studio (paid option): get bakery asset and bake your map or studio as lightmap baked prefab. 
 
there is no other way than pre-baking all of your light to avoid dynamic shadow fps drop.

### Occlusion Probes

for maps, sometimes your map is too slow because the camera is rendering everything in your scene 

you can reduce drawcalls by implementing occlusion probes

it will kinda messup out of bound shot in studio

but it worth the try because it's gonna save your fps

### Don't set anything "Real-time"

most of unity's real-time operation is not really big but if everything is set real time, unity is not going to like that and drop the fps

bake everything as you can.

### You don't need 4k Texture for trashcan

texture optimization is one of the thing you should consider to optimzie your mod

most of small background objects can have 512 to 1024 texture

mid-size obects 1024 to 2048

clothings 2048 to 4096

consider the size and importance of your object. if your object tend to get spotlight often then use higher resolution texture


!> compressing normal map will cause weird rectangle lighting reflection artifacts. i suggest to use lower resolution normal map with no or less compression applied. 

### Do not re-zip your mod

yes. modding tool zip archive method does not compress anything in zipmod making process

but this is all done for optimizing the loading time of the game.

if you have to optimize the size of your zipmod, please compress zipmod itself and don't extract and compress again.

### Use Dependency Loader when it's big

dependency loader is one of plugin i've made, this is used for optimizing the size of your mod and decreasing the loading time of the mod.

if you don't use dependency loader, each asset bundle will save all the dependency to it's bundle and it will cause bloadted bundle size and increased loading time.

consider using dependency loader when your zipmod is really big like map+studio item combo.

## Workflow Performance Optimization

the word optimization is not designed only for 'game performance'. making mod can be faster by automating your process.

here is few things you can do

automatic map thumbmail generation

compiling all studio item icon 

using python to mange things

### Make Templates

make your own template to start new mod. it will reduce the time to make mod

### Everyday Unity Time Saving: Peek

peek is useful tool that adds many thing 
