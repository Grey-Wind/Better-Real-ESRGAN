# 更好的Real-ESRGAN

![Alt](https://repobeats.axiom.co/api/embed/d3293db1f256b1bdb064a1e0f704fc622434e173.svg "Repobeats analytics image")

一个Real-ESRGAN的GUI。

这个GUI支持JPG(JPEG)格式图片优化为PNG格式图片。

原软件需要调用Batch命令或Powershell命令来运行优化指令，而本人并不喜欢每次都要手动输入，更喜欢自动化执行，所以制作了本软件来节省时间。

我目前放弃了脚本拆分，但是对于多语言仍然是在不断支持的。

---

本软件由于考虑到多个编程语言，所以main分支内无核心代码，每种语言的代码都在对应的分支内，目前Qt6已经趋于完善，我也就懒得更新了，后续会先支持WPF、C#与Visual Basic，其余语言暂等我继续进修。

## 设计内容

* [x] 多模型自选优化
* [x] 自选文件优化（此处指自由在任何位置选择图片）
* [x] 批量优化图片
* [ ] 优化视频

## 注意事项

在使用时，请先将您想要优化的图片命名为input，后缀名为png或jpg(jpeg目前不支持)，然后选自己需要的类型进行优化。输出图片为output.png

注意：动漫视频优化是以视频优化方式优化图片，且只支持png格式。

## 使用及参考项目

[![Readme Card](https://github-readme-stats.vercel.app/api/pin/?username=contre&repo=Windows-API-Code-Pack-1.1)](https://github.com/contre/Windows-API-Code-Pack-1.1)

## 图标

图标：汉仪书魂体简；256×256；300px；无加粗倾斜；背景使用星空(密)笔刷；背景颜色RGB->001|164|233，HSV->198|095|091（转载署名，商用需联系本人）
