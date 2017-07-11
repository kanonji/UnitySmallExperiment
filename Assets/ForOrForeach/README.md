## Benchmark of for, foreach with array, List

![Screenshot of profiler on unity 5 6 1p1 personal 64bit](https://user-images.githubusercontent.com/134377/28061667-53dcb1f4-6666-11e7-8ee3-66bbaad40bda.png)

`for`と`foreach`で`array`と`List`を50000000回ループするのを`Profiler.BeginSample()`で計測。
`foreach`より`for`の方が若干早いけど、かなりのループ回数だし、誤差かな？
