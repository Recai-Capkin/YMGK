import cv2
# Load the cascade
face_cascade = cv2.CascadeClassifier('haarcascade_frontalface_default.xml')

# Read the input image
img = cv2.imread('Resim\\20200329_172313.jpg')

# Convert into grayscale
gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)

# Detect faces
faces = face_cascade.detectMultiScale(gray, 1.165, 4)

# Draw rectangle around the faces
for (x, y, w, h) in faces:
    cv2.rectangle(img, (x, y), (x + w, y + h), (255, 0, 0), 2)


scale_percent = 60 # percent of original size
width = int(img.shape[1] * scale_percent / 250)
height = int(img.shape[0] * scale_percent / 350)
dim = (width, height)
  
# resize image
resized = cv2.resize(img, dim, interpolation = cv2.INTER_AREA)
# Display the output
#♥cv2.imshow('img', img)

cv2.imshow('resized',resized)

h, w, c = resized.shape
print('width:  ', w)
print('height: ', h)
print('channel:', c)
# width:   400
# height:  225
# channel: 3

cv2.waitKey()
