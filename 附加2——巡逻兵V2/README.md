### 智能巡逻兵

20337245魏一鸣

实验的基础使用了unity提供的FPS模版

对于订阅发布模式的进一步认识:

1.定义事件监听借口作为事件的注册方式，可以定义一个广播函数，对于所有父类相同的event可以一并处理，这样就做到了对于事件的发布

![image-20221214065007501](C:\Users\Lenovo\AppData\Roaming\Typora\typora-user-images\image-20221214065007501.png)

2.定义所有的事件触发函数，所有的事件可以记录在一起

![image-20221214065046217](C:\Users\Lenovo\AppData\Roaming\Typora\typora-user-images\image-20221214065046217.png)

3.最后在需要的所有地方定义反馈的函数，作为发布的触发（很多时候事件可以提前注册，但是在单个实例中不一定全部使用，所以注册表要大于发布表的）

![image-20221214065223835](C:\Users\Lenovo\AppData\Roaming\Typora\typora-user-images\image-20221214065223835.png)