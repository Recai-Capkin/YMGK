#import tkinter,mainloop,TOP as tk
import os
import sys
from tkinter.ttk import Button
from tkinter import *
import tkvideo as tkv
import cv2


face_cascade = cv2.CascadeClassifier('haarcascade_frontalface_default.xml')

cap = cv2.VideoCapture('Video\\20200429_151651.mp4')

top = Tk();

top.title("Yüz Tanıma Programı")
#top.geometry('750x750')
#top.configure(background='grey')

#button = Button(top, text = 'Recai Çapkın')
#button.pack(side = TOP, pady = 5)

my_label = Label(top)
my_label.pack()
player = tkv.tkvideo("Resim\\20210319_222415.mp4", my_label, loop = 1, size = (1280,720))
player.play()


while True:
    # Read the frame
    _, img = cap.read()
    
    # Convert to grayscale
    gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)

    # Detect the faces
    faces = face_cascade.detectMultiScale(gray, 1.1, 4)

    # Draw the rectangle around each face
    for (x, y, w, h) in faces:
        cv2.rectangle(img, (x, y), (x+w, y+h), (255, 255, 0), 2)
        
        
    imgrs = cv2.resize(img,(1280,720))
        
    # Display
    cv2.imshow('Yuz Tanima Programi', imgrs)
    # Stop if escape key is pressed
    k = cv2.waitKey(30) & 0xff
    if k==27:
        cv2.destroyAllWindows()
        break
        
# Release the VideoCapture object
cap.release()

top.mainloop();