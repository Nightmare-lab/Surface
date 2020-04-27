
from mpl_toolkits.mplot3d import Axes3D
import numpy as np
from matplotlib import cm
import matplotlib.pyplot as plt

def make_surface(a, b, c, d, x_start, x_end, y_start, y_end):
    # уравнение поверхности
    f = lambda x, y: a * x ** 2 + b * y ** 2 + c * np.exp(-x) + d * np.exp(y)
    # создаём полотно для рисунка
    fig = plt.figure(figsize = (10, 10))
    # создаём рисунок пространства с поверхностью
    ax = fig.add_subplot(1, 1, 1, projection = '3d')
    # размечаем границы осей для аргументов
    xval = np.linspace(x_start, x_end, 1000)
    yval = np.linspace(y_start, y_end, 1000)
    # создаём массив с xval столбцами и yval строками
    # - в этом массиве будут храниться значения z
    x, y = np.meshgrid(xval, yval)
    # приравниваем z к функции от x и y 
    z = f(x, y)
    # создаём поверхность
    ax.plot_surface(
    # отмечаем аргументы и уравнение поверхности
    x, y, z, 
    # шаг прорисовки сетки
    # - чем меньше значение, тем плавнее
    # - будет градиент на поверхности
    rstride = 10,
    cstride = 10,
    # цветовая схема plasma
    cmap = cm.plasma)
    plt.show()


def find_square(a, b, c, d):
    # Пределы интегрирования x=[-30, 30], y=[-90, 90]
    return 120 * (2.7e4 * a + 2.43e5 * b + 3 * c * np.sinh(30) + d * np.sinh(90))
    

make_surface(2, 2, 3, 4, -30, 30, -90, 90)
print(f"Площадь выведенной поверхности = {find_square(2, 2, 3, 4)}")