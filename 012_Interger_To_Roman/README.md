## 题目
给定一个 int 数值的数字，转换成罗马数字，例如 1 转成 I, 2 转成 II 等。
罗马数字有下属规则：
1. I = 1
2. V = 5
3. X = 10
4. L = 50
5. C = 100
6. D = 500
7. M = 1000
另外所有数字都需要尽量短的显示，所以5应该写成V, 不应该写成 IIIII;
另外4可以写成 IV, 9可以写成 IX, 以此类推 40， 90， 400， 900等。

## 犯错经历
1. 阅读题目不够仔细，将8表示成了IIX, 应该表示成 VIII，这点不知道之前的设计者是如何考虑的。