
from mpl_toolkits.mplot3d import Axes3D
import numpy as np
from matplotlib import cm
import matplotlib.pyplot as plt
import scipy
import scipy.integrate
import sympy
from sympy.parsing.sympy_parser import parse_expr
import math



def make_surface(a, b, c, d, x_start, x_end, y_start, y_end):
    f = lambda x, y: a * x ** 2 + b * y ** 2 + c * np.exp(-x) + d * np.exp(y)
    fig = plt.figure(figsize = (10, 10))
    
    ax = fig.add_subplot(1, 1, 1, projection = '3d')
    xval = np.linspace(x_start, x_end, 1000)
    yval = np.linspace(y_start, y_end, 1000)
    x, y = np.meshgrid(xval, yval)
    z = f(x, y)
    ax.text(-50,130,-5,f"Square:{square()}",rotation = 38, fontsize = 14)
    ax.plot_surface(
    x, y, z, 
    rstride = 10,
    cstride = 10,
    cmap = cm.plasma)
    plt.show()


def func(x,y):

    xDif = xExp(x,y)
    yDif = yExp(x,y)

    return math.sqrt(1 + xDif**2 + yDif**2)


def square():
    return  scipy.integrate.dblquad(func,-10, 10, -20, 20)  

def xExp(x,y):
    return 4 * x - 3 * math.exp(-x)

def yExp(x,y):
    return 4 * y + 3 * math.exp(y)

make_surface(2, 2, 3, 3, -10, 10, -20, 20)