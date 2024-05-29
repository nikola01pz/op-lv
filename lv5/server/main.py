import tkinter as tk
from tkinter import *
import socket
import threading as thr

import file_handler as fh
import server_handler as sh

class MenuBar:
    def __init__(self, root, file_handler, server_handler):
        self.menubar = Menu(root)
        
        self.filemenu = Menu(self.menubar, tearoff=0)
        self.menubar.add_cascade(label="File", menu=self.filemenu)
        self.filemenu.add_command(label="Open", command=file_handler.open_file)
        self.filemenu.add_command(label="Exit", command=root.quit)
        
        self.servermenu = Menu(self.menubar, tearoff=0)
        self.menubar.add_cascade(label="Server", menu=self.servermenu)
        self.servermenu.add_command(label="Start server", command=server_handler.start_server)
        
        root.config(menu=self.menubar)

class Application(Frame):
    def __init__(self, master=None):
        super().__init__(master)
        self.pack()
        self.create_widgets()

    def create_widgets(self):
        self.canvas = Canvas(self, bg="#999999", width=800, height=600)
        self.canvas.pack()
        self.message_label = self.canvas.create_text(800, 600, anchor='se', text="", fill="black")

        file_handler = fh.FileHandler(self.canvas)
        server_handler = sh.ServerHandler(self.canvas, self.message_label)
        MenuBar(root, file_handler, server_handler)

root = tk.Tk()
root.title("OP LV5 Client-server socket connection")
app = Application(root)
app.mainloop()
