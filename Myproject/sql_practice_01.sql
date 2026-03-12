USE college;
/* CREATE TABLE students (
    id INT PRIMARY KEY AUTO_INCREMENT,
    full_name VARCHAR(255) NOT NULL,
    group_name VARCHAR(50) NOT NULL,
    course INT CHECK (course BETWEEN 1 AND 4),
    avg_grade DECIMAL(5,2) CHECK (avg_grade BETWEEN 0 AND 100),
    is_active TINYINT(1) CHECK (is_active IN (0, 1)),
    scholarship DECIMAL(10,2) DEFAULT 0,
    enrolled_year INT
);
/* INSERT INTO students (full_name, group_name, course, avg_grade, is_active, scholarship, enrolled_year) VALUES
('Іваненко Петро', 'ІПЗ-11', 1, 92.5, 1, 2000, 2025),
('Петренко Ганна', 'ІПЗ-11', 1, 55.0, 1, 0, 2025),
('Сидоренко Олег', 'ІПЗ-21', 2, 88.0, 1, 1500, 2024),
('Коваленко Марія', 'ІПЗ-21', 2, 72.5, 1, 1000, 2024),
('Бондаренко Ігор', 'ІПЗ-31', 3, 95.0, 1, 2500, 2023),
('Мельник Юлія', 'ІПЗ-31', 3, 45.0, 0, 0, 2023),
('Шевченко Артем', 'ІПЗ-11', 1, 78.0, 1, 1000, 2025),
('Ткаченко Олена', 'ІПЗ-21', 2, 86.5, 1, 1500, 2024),
('Кравченко Віталій', 'ІПЗ-41', 4, 65.0, 1, 0, 2022),
('Олійник Світлана', 'ІПЗ-41', 4, 91.0, 1, 2000, 2022),
('Лисенко Дмитро', 'ІПЗ-21', 2, 59.0, 0, 0, 2024),
('Руденко Надія', 'ІПЗ-31', 3, 82.0, 1, 1200, 2023),
('Мороз Вадим', 'ІПЗ-11', 1, 61.0, 1, 0, 2025),
('Павленко Вікторія', 'ІПЗ-21', 2, 89.0, 1, 1800, 2024),
('Савченко Сергій', 'ІПЗ-41', 4, 74.0, 0, 0, 2022);*/
SELECT * FROM students 
WHERE group_name = 'ІПЗ-11' AND enrolled_year > 2023 
ORDER BY enrolled_year DESC;