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
        canvas.create_rectangle(self.dot[0], self.dot[1], float(self.width) + float(self.dot[0]), float(self.height) + float(self.dot[1]), outline=self.color, fill="")

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