import unittest
bdLibPath = os.path.abspath(sys.argv[0] + "..")
if not bdLibPath in sys.path:
    sys.path.append(bdLibPath)
from _lib import *

test_name = "Test no courses"

class TestNoCourses(unittest.TestCase):

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def test_001_LoginTALS(self):
        LoginUser("FreshNewUser1", "123456")
        wait(TALS.fresh_new_user_logo, 30)

    def test_002_OpenUserMenu(self):
        wait(TALS.fresh_new_user_home_logo, 30)
        hover(TALS.fresh_new_user_home_logo)
        wait(TALS.no_courses_menu, 3)

    def test_999_LogOut(self):
        wait(10)
        for i in range(5):
            type(Key.UP)
        click(TALS.button_logout)

if __name__ == '__main__':
    LogTestResults(test_name, TestNoCourses)