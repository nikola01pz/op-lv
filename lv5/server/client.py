import socket
import threading as thr

def Srv_func(cs):
    while True:
        message = cs.recv(1024).decode()
        print(message)
        
if __name__ == '__main__':
    listensocket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    port = 8000
    maxConnections = 10
    name = socket.gethostname() 
    listensocket.bind(('localhost',port))
    listensocket.listen(maxConnections)
    print("Started server at " + name + " on port " + str(port))
 
while True:
    (clientsocket, address) = listensocket.accept()
    print("New connection made from address: ", address)
    t = thr.Thread(target=Srv_func, args=(clientsocket,))
    t.daemon = True
    t.start()