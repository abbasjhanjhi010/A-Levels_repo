Imports System

Module Program
    Class Lesson
        Private LessonTitle As String
        Private DurationMinutes As Integer
        Private RequiresLab As Boolean

        Public Sub Create(ByVal Lesson As String, ByVal duration As Integer, ByVal RequiLab As Boolean)
            Me.LessonTitle = Lesson
            Me.DurationMinutes = duration
            Me.RequiresLab = RequiLab
        End Sub

        Public Sub OutputLessonDetails()
            Console.WriteLine(LessonTitle, DurationMinutes, RequiresLab)
        End Sub
    End Class

    Class Assessment
        Private AssessmentTitle As String
        Private MaxMarks As Integer

        Public Sub Create(ByVal Assessment As String, ByVal Marks As Integer)
            Me.AssessmentTitle = Assessment
            Me.MaxMarks = Marks
        End Sub

        Public Sub AssessmentDetails()
            Console.WriteLine("{0}, {1}", AssessmentTitle, MaxMarks)
        End Sub
    End Class

    Class Course
        Private CourseTitle As String
        Private MaxStudents As Integer
        Private NUmberOfLessons As Integer = 0
        Private CourseLesson(50) As Lesson
        Private CourseAssessment As Assessment

        Public Sub Create(ByVal Title As String, ByVal MaxStdts As Integer)
            CourseTitle = Title
            MaxStudents = MaxStdts
        End Sub

        Sub AddLesson(ByVal Lesson As String, ByVal Duration As Integer, ByVal RequiLab As Boolean)
            NUmberOfLessons += 1
            CourseLesson(NUmberOfLessons) = New Lesson
            CourseLesson(NUmberOfLessons).Create(Lesson, Duration, RequiLab)
        End Sub

        Public Sub AddAssessment(ByVal Assessment As String, ByVal Marks As Integer)
            CourseAssessment = New Assessment
            CourseAssessment.Create(Assessment, Marks)
        End Sub

        Public Sub OutputCourseDetails()
            Console.WriteLine(CourseTitle & "Maximum number: " & MaxStudents)
            For i = 1 To NUmberOfLessons
                CourseLesson(i).OutputLessonDetails()
            Next
        End Sub
    End Class


    Sub Main(args As String())
        Dim MyCourse As New Course
        MyCourse.Create("Computing", 10)
        MyCourse.AddAssessment("Programming", 100)
        MyCourse.AddLesson("Problem Solving", 60, False)
        MyCourse.AddLesson("Programming", 120, True)
        MyCourse.AddLesson("Theory", 60, False)
        MyCourse.AddLesson("Operating  System", 87, False)
        MyCourse.AddLesson("Hardware and Software", 81, False)
        MyCourse.AddLesson("Binary", 65, False)
        MyCourse.AddLesson("AI Machine Learning", 11, False)


        MyCourse.OutputCourseDetails()
        Console.ReadKey()
    End Sub
End Module
