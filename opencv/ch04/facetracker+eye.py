import cv2


def main():
    camera = cv2.VideoCapture(0)
    camera.set(3, 640)
    camera.set(4, 480)

    face_xml = (
        "C:\MyMoble\OpenCV\opencv\data\haarcascades\haarcascade_frontalface_default.xml"
    )
    eye_xml = "C:\MyMoble\OpenCV\opencv\data\haarcascades\haarcascade_eye.xml"

    face_cascade = cv2.CascadeClassifier(face_xml)
    eye_cascade = cv2.CascadeClassifier(eye_xml)

    while camera.isOpened():
        _, image = camera.read()
        gray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)

        faces = face_cascade.detectMultiScale(
            gray,
            scaleFactor=1.1,
            minNeighbors=5,
            minSize=(100, 100),
            flags=cv2.CASCADE_SCALE_IMAGE,
        )
        print("faces detected Number: " + str(len(faces)))

        if len(faces):
            timer = 1000
            for x, y, w, h in faces:
                cv2.rectangle(image, (x, y), (x + w, y + h), (255, 0, 0), 2)

                face_gray = gray[y : y + h, x : x + w]
                face_color = image[y : y + h, x : x + w]

                eyes = eye_cascade.detectMultiScale(
                    face_gray, scaleFactor=1.1, minNeighbors=5
                )

                if len(eyes) <= 1:
                    # buzzer sound
                    timer -= 1
                if timer == 0:
                    print("buzzer sound")

                for ex, ey, ew, eh in eyes:
                    cv2.rectangle(
                        face_color, (ex, ey), (ex + ew, ey + eh), (0, 255, 0), 2
                    )
        cv2.imshow("result", image)
        if cv2.waitKey(1) == ord("q"):
            break
    cv2.destroyAllWindows()


if __name__ == "__main__":
    main()
