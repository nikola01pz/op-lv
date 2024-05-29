from tkinter import filedialog as fd
import objects as ob

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
                shape = ob.Line(color, dot, dot2)
            elif shape_type == 'Triangle':
                dot2 = (float(parameters[4]), float(parameters[5]))
                dot3 = (float(parameters[6]), float(parameters[7]))
                shape = ob.Triangle(color, dot, dot2, dot3)
            elif shape_type == 'Rectangle':
                height = float(parameters[4])
                width = float(parameters[5])
                shape = ob.Rectangle(color, dot, height, width)
            elif shape_type == 'Polygon':
                dots = [(float(parameters[i]), float(parameters[i + 1])) for i in range(4, len(parameters), 2)]
                shape = ob.Polygon(color, dot, dots)
            elif shape_type == 'Circle':
                radius = float(parameters[4])
                shape = ob.Circle(color, dot, radius)
            elif shape_type == 'Ellipse':
                radius_x = float(parameters[4])
                radius_y = float(parameters[5])
                shape = ob.Ellipse(color, dot, radius_x, radius_y)

            if shape:
                shape.draw(self.canvas)