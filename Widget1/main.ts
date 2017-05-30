let Chart: any;

(function () {
    
    var widgetElement: Element = document.getElementById('this');
    var widget: WidgetComponent = new WidgetComponent(widgetElement, {
        loadData: (e: Element) => {

            $('h3', e).text('Test 123');

            console.log(e);

            var canvas = <HTMLCanvasElement>e.getElementsByTagName('canvas').item(0);

            console.log(canvas);

            var ctx = canvas.getContext('2d');

            console.log(ctx);

            var myChart = new Chart(ctx, {
                type: 'bar',
                data: {
                    labels: ["Red", "Blue", "Yellow", "Green", "Purple", "Orange"],
                    datasets: [{
                        label: '# of Votes',
                        data: [12, 19, 3, 5, 2, 3],
                        backgroundColor: [
                            'rgba(255, 99, 132, 0.2)',
                            'rgba(54, 162, 235, 0.2)',
                            'rgba(255, 206, 86, 0.2)',
                            'rgba(75, 192, 192, 0.2)',
                            'rgba(153, 102, 255, 0.2)',
                            'rgba(255, 159, 64, 0.2)'
                        ],
                        borderColor: [
                            'rgba(255,99,132,1)',
                            'rgba(54, 162, 235, 1)',
                            'rgba(255, 206, 86, 1)',
                            'rgba(75, 192, 192, 1)',
                            'rgba(153, 102, 255, 1)',
                            'rgba(255, 159, 64, 1)'
                        ],
                        borderWidth: 1
                    }]
                },
                options: {
                    scales: {
                        yAxes: [{
                            ticks: {
                                beginAtZero: true
                            }
                        }]
                    }
                }
            });

        },
        saveCustomisation: (customisation: { [id: string]: any }): void => { },
        restoreCustomisation: (customisation: { [id: string]: any }): void => { }
    });

    WidgetManager.Instance.registerWidget(widget);

})();