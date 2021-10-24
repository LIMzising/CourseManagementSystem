var events = [];
$(".events").each(function () {
    var title = $(".title", this).text().trim();
    var start = $(".start", this).text().trim();
    var event = {
        "title": title,
        "start": start
    };
    events.push(event);
});
$("#calendar").fullCalendar({
    locale: 'au',
    events: events,
    timeFormat: 'H(:mm)', // uppercase H for 24-hour clock、
    displayEventTime: false,
    businessHours: {
        dow: [1, 2, 3, 4, 5], // Monday - Friday
    },
    dayClick: function (date, allDay, jsEvent, view) {
        if (date.isBefore(moment()))
        {
            alert("Cannot book historical dates");
            return false;
            
        } else if (moment(date).day() == 0 || moment(date).day() == 6)
        {
            alert("Cannot book out of business days");
            return false;
        }
        else
        {
            var d = new Date(date);
            var m = moment(d).format("YYYY-MM-DD");
            m = encodeURIComponent(m);
            var uri = "/Bookings/Create?date=" + m;
            $(location).attr('href', uri);
        }
    }
});
