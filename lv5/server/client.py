import socket
import threading as thr
def Srv_func(cs): #Funkcija koja će se izvršavati za svakog klijenta nezavisno u zasebnoj niti
    while True:
        message = cs.recv(1024).decode() #Dohvaća poslanu poruku i dekodira u string
        print(message)
if __name__ == '__main__':
 listensocket = socket.socket(socket.AF_INET, socket.SOCK_STREAM) #Stvara socket objekt
 port = 8000
 maxConnections = 10
 name = socket.gethostname() #Naziv lokalnog računala
 listensocket.bind(('localhost',port)) #Može i '127.0.0.1'
 listensocket.listen(maxConnections) #Pokreće server
 print("Started server at " + name + " on port " + str(port))
while True:
    (clientsocket, address) = listensocket.accept() #Prihvaća nadolazeću konekciju
    print("New connection made from address: ", address)
    t = thr.Thread(target=Srv_func, args=(clientsocket,)) #Stvara novu nit za obradu konekcije
    t.daemon = True
    t.start()