import socket
import threading as thr

import objects as ob

class ServerHandler:
    def __init__(self, canvas, message_label):
        self.server_thread = None
        self.canvas = canvas
        self.message_label = message_label

    def start_server(self):
        if self.server_thread is None or not self.server_thread.is_alive():
            self.server_thread = thr.Thread(target=self.run_server)
            self.server_thread.daemon = True
            self.server_thread.start()
            print("Server started...")

    def run_server(self):
        def Srv_func(cs):
            while True:
                try:
                    message = cs.recv(1024).decode()
                    if message:
                        print(message)
                        parameters = message.split()
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
                    else:
                        break
                except ConnectionResetError:
                    break
            cs.close()

        listensocket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        port = 8000
        maxConnections = 10
        name = socket.gethostname()
        listensocket.bind(('localhost', port))
        listensocket.listen(maxConnections)
        server_message = f"Started server at {name} on port {port}"
        print(server_message)
        self.canvas.itemconfigure(self.message_label, text=server_message)

        while True:
            clientsocket, address = listensocket.accept()
            print("New connection made from address: ", address)
            t = thr.Thread(target=Srv_func, args=(clientsocket,))
            t.daemon = True
            t.start()