import unittest
bdLibPath=os.path.abspath(sys.argv[0]+"..")
if not bdLibPath in sys.path: sys.path.append(bdLibPath)
from _lib import *

test_name = "TestWithNewInstanc"

class TestWithNewInstanc(unittest.TestCase):
    def setUp(self):
        pass

    def tearDown(self):
        pass

    __activity = True
    __visibility = True
    def test_001_ActiveAndVissibleCourseDisplay(self):
        AddNewInstance(self.__activity, self.__visibility)
        ExpandCoursesNavigation()

        assert exists(CreateCourse.navigation_sikuli_button)

    def test_002_OnlyVissibleCourseDisplay(self):
        self.__activity = False
        self.__visibility = True

        AddNewInstance(self.__activity, self.__visibility)
        ExpandCoursesNavigation()

        assert not exists(CreateCourse.navigation_sikuli_button)

    def test_003_OnlyActiveCourseDisplay(self):
        self.__activity = True
        self.__visibility = False

        AddNewInstance(self.__activity, self.__visibility)
        ExpandCoursesNavigation()

        assert not exists(CreateCourse.navigation_sikuli_button)

    def test_004_NotActiveNotVisibleCorseDisplay(self):
        self.__activity = False
        self.__visibility = False

        AddNewInstance(self.__activity, self.__visibility)
        ExpandCoursesNavigation()

        assert not exists(CreateCourse.navigation_sikuli_button)



if __name__ == '__main__':
    LogTestResults(test_name, TestWithNewInstanc)