import unittest
bdLibPath = os.path.abspath(sys.argv[0] + "..")
if not bdLibPath in sys.path:
    sys.path.append(bdLibPath)
from _lib import *

test_name = "Test my courses"

class TestMyCourses(unittest.TestCase):

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def test_001_LoginTALS(self):
        #LogInTALS()
        #wait(TALS.giant_test_user_logo,30)

        LoginUser("GiantTestUser", "123456")
        wait(Log.giant_test_user_logo, 30)
    
    def test_002_OpenMyCourses(self):
        OpenMyCourses()
        assert exists (TALS.my_courses)
        
    def test_003_OpenDSACourse(self):
        wait(10)
        for i in range(5):
            type(Key.UP)
        OpenMyCourses()
        wait(TALS.course_dsa, 3)
        click(TALS.course_dsa)
        wait(10)
        for i in range(5):
            type(Key.DOWN)
        wait(TALS.course_dsa_logo, 30)
        assert exists (TALS.course_dsa_logo)
        
    def test_004_OpenCSharpTwoCourse(self):
        wait(10)
        for i in range(5):
            type(Key.UP)
        OpenMyCourses()
        wait(TALS.c_sharp_part_two, 3)
        click(TALS.c_sharp_part_two)
        wait(10)
        for i in range(5):
            type(Key.DOWN)
        wait(TALS.course_c_sharp_part_two_logo, 30)
        assert exists (TALS.course_c_sharp_part_two_logo)
        
    def test_005_OpenTestCourseTwo(self):
        wait(10)
        for i in range(5):
            type(Key.UP)
        OpenMyCourses()
        wait(TALS.test_course_two, 3)
        click(TALS.test_course_two)
        wait(10)
        for i in range(5):
            type(Key.DOWN)
        wait(TALS.test_course_two_logo)
        assert exists (TALS.test_course_two_logo)
        
    def test_999_LogOut(self):
        wait(10)
        for i in range(5):
            type(Key.UP)
        click(TALS.button_logout)
    
if __name__ == '__main__':
    LogTestResults(test_name, TestMyCourses)