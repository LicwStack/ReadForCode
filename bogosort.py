import random

inputs = [1, 45, 2, 5, 23, 22, 56, 9]


def is_sorted(collection):
    if len(collection) < 2:
        return True
    for i in range(len(collection) - 1):
        if collection[i] > collection[i + 1]:
            return False
    return True


while not is_sorted(inputs):
    random.shuffle(inputs)  //-- shuffle() 方法将序列的所有元素随机排序。
                            //--- shuffle()是不能直接访问的，需要导入 random 模块，然后通过 random 静态对象调用该方法。

print(inputs)
