using MetricsManager.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MetricsManagerTests
{
    public class DotNetAgentTests
    {

        private DotNetMetricsController _dotNetMetricsController;

        public DotNetAgentTests()
        {
            _dotNetMetricsController = new DotNetMetricsController();
        }

        [Fact]
       
            // TODO: �������� ������� [����� 3]
            //  �������� ������ � ������� ��� ������ ����� ������. �������� ������� Unit-����� �� ������
            // ����� �������� ������� ����������� � ����� �������� ��������.

            // �� ������ ������ ����� ������ ��������������� ���������� (��� � ������� MetricsManagerTests)

        public void GetMetricsFromAgent_ReturnOk()
        {
            TimeSpan fromTime = TimeSpan.FromSeconds(0);
            TimeSpan toTime = TimeSpan.FromSeconds(100);

            IActionResult result = _dotNetMetricsController.GetMetrics(fromTime, toTime);

            Assert.IsAssignableFrom<IActionResult>(result);


        }
    }
}
