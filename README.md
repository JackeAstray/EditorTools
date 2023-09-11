### Unity Editor Tools And Game Framework
Unity编辑器工具<br>
Unity版本：2021.3.15f<br>

- [功能](#Function)
- [文件夹结构](#FolderStructure)

## 功能：<a name="Function"></a>
1）Excel导出为.cs|.xml|.json|.lua文件。<br>
2）日志系统<br>
3）打开指定路径文件夹<br>
4）生成脚本工具<br>
5）扩展功能<br>
6）广告牌<br>
7）编译器模式碰撞器绘制<br>
8）FPS控制<br>
9）焦点工具（查找资源并将该资源设为焦点 快捷键Control + L）<br>
10）将图片空白区域切割工具 (在需要切割的图片上点击右键选中“切割图片空白区域”即可)<br>
11）图片导入自动修改类型大小（指定目录下才有用Assets\Resources\Sprites）<br>
12）UI工具<br>
13）小功能（包含的功能有给场景添加屏幕日志、给场景添加FPS、给场景选中的对象添加多语言用脚本、场景切换、修改版本号）<br>
14）App系统（该系统用于启动执行数据、事件、多语言、对象池、资源、场景、声音、终端、UI等模块）<br>

## 文件夹结构：<a name="FolderStructure"></a>
|-3RD                   用于存放第三方库<br>
|-Editor                用于存放第三方库<br>
---|Scenes              用于存放生成UI的场景<br>
|-Resources             资源文件夹<br>
|-ReunionMovement       模块化插件（每个单独的模块都会放入其中）<br>
---|-APP                APP是用于启动各个模块系统<br>
------|-Base            APP的基础功能<br>
------|-Module          APP的各个模块<br>
---------|-DatabaseModule    数据模块<br>
---------|-EventModule       事件模块<br>
---------|-LanguagesModule   多语言模块<br>
---------|-ObjectPoolModule  对象池模块<br>
---------|-ResourcesModule   资源模块<br>
---------|-SceneModule       场景模块<br>
---------|-SoundModule       声音模块<br>
---------|-TerminalModule    终端模块<br>
---------|-UIModule          UI模块<br>
------|-StartApp        APP的启动脚本<br>
---|-Common             公用类<br>
------|-Observer        观察者模式基类<br>
------|-SingleToneMgr   单例模式基类<br>
------|-PathUtils       单例模式基类<br>
------|-Editor          <br>
---------|-ScriptingDefineSymbols  脚本宏<br>
---|-ExcelTool          表格导出工具(用于导出.cs|.xml|.json|.lua文件)<br>
---|-Extensions         扩展功能脚本<br>
---|-GenerateScriptTool 创建脚本工具<br>
---|-LogTool            日志工具，集成了宏命令可开启和关闭Log<br>
---|-OpenPath           打开指定路径文件夹<br>
---|-SmallFunctions     小功能<br>
---|-SplitImg           图片自动裁切留白区域  需要此路径../Tools/SplitImg/SplitImg.exe下的EXE<br>
---|-Spotlight          焦点工具、用于搜索对象<br>
---|-TextureImporter    图片导入Assets\Resources\Sprites路径时自动修改图片配置<br>
---|-Toolbox            工具箱<br>
------|-Billboard       广告牌<br>
------|-ColliderGizmo   碰撞器绘制（编辑器下碰撞器会有颜色）<br>
------|-DownloadFile    下载文件<br>
------|-Http            Http网络访问<br>
------|-LitJson         LitJson源码<br>
------|-LoadImage       加载Image<br>
------|-Screen          屏幕适配<br>
------|-ScreenLogger    Log显示在屏幕上<br>
------|-TextRect        Text自动改变宽高<br>
------|-Timer           时间管理器<br>
------|-FPSCounter      FPS计数器<br>
|-Scenes                场景文件夹<br>
|-Scripts               脚本文件夹<br>
|-Settings              URP配置文件<br>
