### 坦克大战

20337245魏一鸣

##### 素材简介

本次试验用到的是unity store中的kavaii tank 2.0 version

相较于在网上普遍找到的1.1版本的使用资料，2.0版本提供了多平台的服务借口（本实验用不到），并且对待吗进行了重构，降低了代码

的耦合度



##### 实验要素与困难

本次试验的重点是学会使用unity自带的导航功能并对AI的具体原理以及实现有一个初步的了解

* 关于navigation
  * 调用NavMeshagent.destination设置目标点，如果目标点是不可达的点，那么结果是destination存放了离目标点最近的点
  * 对于navigator的bake过程，会产生很多莫名其妙的不可通过位置，所以在bake过程中尽量减少弧形位置，或者可能可以手动链接（？）
  * 这条不仅仅关于navigation，对于很多组件的安装，应该直接安装在最靠下的子层级，例如下图中，组件应该安装在MainBody下，而不是预制件SD_Firefly_2.0

![image-20221210105923120](C:\Users\Lenovo\AppData\Roaming\Typora\typora-user-images\image-20221210105923120.png)

* 关于实验软装置

  * 在Fire_Control_CS下修改Update如下

    ![image-20221210110942086](C:\Users\Lenovo\AppData\Roaming\Typora\typora-user-images\image-20221210110942086.png)

  * 炮口的旋转是锁定的，但是研究代码的时候它本身有旋转炮口的方法，有三种模式，0为锁定，1为解锁但不移动，2为索敌但是实际上会一直保持锁定状态。可能是因为开火实际上应当是和转向是配套的，但是由于直接使用了Fire的方法，对于转向的修改没有发生（实在是没找到接口，他也没给个API）

  * 由于炮口是锁定的，所以由于抬得太高，AI永远打不到玩家，所以我们需要加大玩家的Scale