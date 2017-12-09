## Non static GameObject in Static GameObject

![unity 5 6 3p1 personal 64bit - main unity - unitysmallexperiment - pc mac linux standalone_ _dx11_ 2017-12-09 16 05 36](https://user-images.githubusercontent.com/134377/33793396-d0402ee6-dcfa-11e7-920c-02c79d39ffaa.png)

親GameObjectや子GameObjectのStaticの設定に関わらず、自身のStaticの設定だけを考慮している様子。
少なくともLightmap Staticはそういう挙動。


## 補足

![unity 5 6 3p1 personal 64bit - main unity - unitysmallexperiment - pc mac linux standalone _dx11_ 2017-12-09 15 54 59](https://user-images.githubusercontent.com/134377/33793324-5392d14c-dcf9-11e7-92a2-87a4fc977888.png)

1. Environment Lighting -> Ambient Modeを`Realtime` -> `Baked`に変更
2. Auto Generateを`Off`
3. Generate Lightingを実行
4. Environment Lighting -> Intensity Multiplierを`1` -> `0`に変更

StaticなGameObjectはIntensity Multiplier: `1`で焼いたLightmaの影響が残り続け光が当たっている状態のままだが、Non Staticな方はIntensity Multiplier: `0`にすると光が全く当たらない状態になり、黒くなった。
