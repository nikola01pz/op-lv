import tkinter as tk
from tkinter import *
from tkinter import filedialog as fd

class GraphicObject:
    def __init__(self, color, dot):
        self.color = color
        self.dot = dot

    def set_color(self, color):
        self.color = color

    def get_color(self):
        return self.color

    def draw(self, canvas):
        pass

class Line(GraphicObject):
    def __init__(self, color, start_dot, end_dot):
        super().__init__(color, start_dot)
        self.end_dot = end_dot

    def draw(self, canvas):
        canvas.create_line(self.dot, self.end_dot, fill=self.color)

class Triangle(Line):
    def __init__(self, color, dot1, dot2, dot3):
        super().__init__(color, dot1, dot2)
        self.dot3 = dot3

    def draw(self, canvas):
        canvas.create_polygon(self.dot, self.end_dot, self.dot3, outline=self.color, fill="")

class Rectangle(GraphicObject):
    def __init__(self, color, dot, height, width):
        super().__init__(color, dot)
        self.height = height
        self.width = width

    def draw(self, canvas):
        canvas.create_rectangle(self.dot, (self.dot[0] + self.width, self.dot[1] - self.height), outline=self.color, fill="")

class Polygon(GraphicObject):
    def __init__(self, color, dot, dots):
        super().__init__(color, dot)
        self.dots = dots

    def draw(self, canvas):
        canvas.create_polygon(self.dot, *self.dots, outline=self.color, fill="")

class Circle(GraphicObject):
    def __init__(self, color, dot, radius):
        super().__init__(color, dot)
        self.radius = radius

    def draw(self, canvas):
        left_dot = (self.dot[0] - self.radius, self.dot[1] + self.radius)
        right_dot = (self.dot[0] + self.radius, self.dot[1] - self.radius)
        canvas.create_oval(left_dot, right_dot, outline=self.color, fill="")

class Ellipse(Circle):
    def __init__(self, color, dot, radius_x, radius_y):
        super().__init__(color, dot, radius_x)
        self.radius_y = radius_y

    def draw(self, canvas):
        left_dot = (self.dot[0] - self.radius, self.dot[1] - self.radius_y)
        right_dot = (self.dot[0] + self.radius, self.dot[1] + self.radius_y)
        canvas.create_oval(left_dot, right_dot, outline=self.color, fill="")

class FileHandler:
    def __init__(self, canvas):
        self.canvas = canvas

    def open_file(self):
        rawFile = fd.askopenfilename()
        with open(rawFile, 'r') as file:
            data = file.read().splitlines()
        
        for d in data:
            parameters = d.split()
            color = parameters[1]
            dot = (float(parameters[2]), float(parameters[3]))
            shape_type = parameters[0]
            shape = None
            
            if shape_type == 'Line':
                dot2 = (float(parameters[4]), float(parameters[5]))
                shape = Line(color, dot, dot2)
            elif shape_type == 'Triangle':
                dot2 = (float(parameters[4]), float(parameters[5]))
                dot3 = (float(parameters[6]), float(parameters[7]))
                shape = Triangle(color, dot, dot2, dot3)
            elif shape_type == 'Rectangle':
                height = float(parameters[4])
                width = float(parameters[5])
                shape = Rectangle(color, dot, height, width)
            elif shape_type == 'Polygon':
                dots = [(float(parameters[i]), float(parameters[i + 1])) for i in range(4, len(parameters), 2)]
                shape = Polygon(color, dot, dots)
            elif shape_type == 'Circle':
                radius = float(parameters[4])
                shape = Circle(color, dot, radius)
            elif shape_type == 'Ellipse':
                radius_x = float(parameters[4])
                radius_y = float(parameters[5])
                shape = Ellipse(color, dot, radius_x, radius_y)

            if shape:
                shape.draw(self.canvas)

class MenuBar:
    def __init__(self, root, file_handler):
        self.menubar = Menu(root)
        self.filemenu = Menu(self.menubar, tearoff=0)
        self.filemenu.add_command(label="Open", command=file_handler.open_file)
        self.filemenu.add_command(label="Exit", command=root.quit)
        self.menubar.add_cascade(label="File", menu=self.filemenu)
        root.config(menu=self.menubar)

class Application(Frame):
    def __init__(self, master=None):
        super().__init__(master)
        self.pack()
        self.create_widgets()

    def create_widgets(self):
        self.canvas = Canvas(self, bg="#999999", width=800, height=600)
        self.canvas.pack()

        file_handler = FileHandler(self.canvas)
        MenuBar(root, file_handler)

root = tk.Tk()
root.title("OP LV4 Python")
app = Application(root)
app.mainloop()
