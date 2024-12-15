CREATE TABLE students (
    id INT PRIMARY KEY IDENTITY(1,1),
    full_name VARCHAR(MAX) NULL,
    student_id VARCHAR(MAX) NULL,
    date DATE NULL,
    payment VARCHAR(MAX) NULL,
    date_create DATE NULL,
    room_id INT,
    FOREIGN KEY (room_id) REFERENCES rooms(id)
);

CREATE TABLE rooms (
    id INT PRIMARY KEY IDENTITY(1,1),
    room_no INT NULL,
    room_status VARCHAR(MAX) NULL,
    date_create DATE NULL,
    location VARCHAR(MAX) NULL
);

SELECT * FROM students