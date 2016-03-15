import unittest
bdLibPath = os.path.abspath(sys.argv[0] + "..")
if not bdLibPath in sys.path:
    sys.path.append(bdLibPath)
from _lib import *

test_name = "Students statistics by age"

class TestStudentsStatisticsByAge(unittest.TestCase):

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def test_001_LoginTALS(self):
        LoginUser("GiantTestUser", "123456")
        wait(TALS.giant_test_user_logo, 30)

    def test_002_NavigateToStudetsStatisticsByAgePage(self):
        wait(Admin.button_admin ,30)
        click(Admin.button_admin)
        wait(10)
        wheel(WHEEL_DOWN, 5)
        wait(Admin.button_students_statistics_by_age, 5).highlight(2)
        click(Admin.button_students_statistics_by_age)
        wait(3)

    def test_003_TestFiveYearsRange(self):
        type(Key.PAGE_DOWN)
        wait(StudentsStatisticsByAge.menu_years_select, 30)
        wait(1)
        click(StudentsStatisticsByAge.menu_select_course)
        wait(1)
        click(StudentsStatisticsByAge.select_all_courses)
        wait(1)
        wheel(WHEEL_DOWN, 10)
        wait(1)
        wait(StudentsStatisticsByAge.five_years_range)
        wheel(WHEEL_UP, 30)

    def test_004_TestTenYearsRange(self):
        type(Key.PAGE_DOWN)
        wait(StudentsStatisticsByAge.menu_years_select, 30)
        click(StudentsStatisticsByAge.menu_years_select)
        wait(1)
        click(StudentsStatisticsByAge.select_ten_years)
        wheel(WHEEL_DOWN, 10)
        wait(1)
        wait(StudentsStatisticsByAge.ten_years_range)
        wheel(WHEEL_UP, 30)

    def test_005_TestThreeYearsRange(self):
        wheel(WHEEL_DOWN, 7)
        wait(StudentsStatisticsByAge.menu_years_range_select, 30).highlight(2)
        click(Pattern((StudentsStatisticsByAge.menu_years_range_select)).targetOffset(86,25))
        wait(1)
        click(StudentsStatisticsByAge.select_three_years)
        wheel(WHEEL_DOWN, 10)
        wait(1)
        wait(StudentsStatisticsByAge.three_years_range)
        wheel(WHEEL_UP, 30)

    def test_006_TestTwoYearsRange(self):
        wheel(WHEEL_DOWN, 7)
        wait(StudentsStatisticsByAge.menu_years_range_select, 30).highlight(2)
        click(Pattern((StudentsStatisticsByAge.menu_years_range_select)).targetOffset(86,25))
        wait(1)
        click(Pattern(StudentsStatisticsByAge.select_two_years).similar(0.8))
        wheel(WHEEL_DOWN, 10)
        wait(1)
        wait(StudentsStatisticsByAge.two_years_range)
        wheel(WHEEL_UP, 30)

    def test_007_TestOneYearRange(self):
        wheel(WHEEL_DOWN, 7)
        wait(StudentsStatisticsByAge.menu_years_range_select, 30).highlight(2)
        click(Pattern((StudentsStatisticsByAge.menu_years_range_select)).targetOffset(86,25))
        wait(1)
        click(StudentsStatisticsByAge.select_one_year)
        wheel(WHEEL_DOWN, 10)
        wait(1)
        wait(StudentsStatisticsByAge.one_year_range)
        wheel(WHEEL_UP, 30)

    def test_999_LogOut(self):
        wait(10)
        wheel(WHEEL_UP, 30)
        click(TALS.button_logout)

if __name__ == '__main__':
    LogTestResults(test_name, TestStudentsStatisticsByAge)