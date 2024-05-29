import socket
import threading as thr

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
        def Srv_func(cs):  # Function to handle each client connection
            while True:
                try:
                    message = cs.recv(1024).decode()  # Receive and decode message
                    if message:
                        print(message)
                    else:
                        break
                except ConnectionResetError:
                    break
            cs.close()

        listensocket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)  # Create socket object
        port = 8000
        maxConnections = 10
        name = socket.gethostname()  # Get local computer name
        listensocket.bind(('localhost', port))  # Bind to localhost
        listensocket.listen(maxConnections)  # Start listening for connections
        server_message = f"Started server at {name} on port {port}"
        print(server_message)
        self.canvas.itemconfigure(self.message_label, text=server_message)

        while True:
            clientsocket, address = listensocket.accept()  # Accept incoming connection
            print("New connection made from address: ", address)
            t = thr.Thread(target=Srv_func, args=(clientsocket,))  # Create a new thread for the connection
            t.daemon = True
            t.start()