
var �������������������;
$(document).ready
(
	function ()
	{
		$(".�����").draggable({cursor: 'move', handle: 'div'});
		$(".�����").resizable();

		$('.������������� td').click(function(){
			������������������� = this;
			var �������������� = $(this).position();
			$('#�������������_��������').css({
				'top': (��������������.top + 1) + 'px',
				'left': (��������������.left + 1) + 'px',
				'width': $(this).width(),
				'height': $(this).height()
			}).val($(this).html()).show().focus();
		});

		$('#�������������_��������').blur(function(){
			$(this).hide();
			$(�������������������).html($(this).val());
		});

	}
)
var ����� = false;
function �������������������(��������)
{
		return Math.round(Math.random() * ��������);
}
function ���������������()
{
	if (����� == true)
	{
		return;
	}
	����� = true;
	�����.innerText = �������������������(1000000000000000);
	����� = new Date();
	$.ajaxSetup({ scriptCharset: "utf-8", contentType: "application/json; charset=utf-8" });
	$.ajax({
		url: 'http://127.0.0.1:1337/Catalogs/Nomenklatura?callback=?',
		dataType: 'json',
		data: { Code: �������������������(100) },
		jsonpCallback: '�������������',
	});
}
function �������������()
{
	���������������();
	//setInterval(���������������, 100);
}
function �������������(������)
{
	������������.value	= ������.������������;
	�������������.value	= ������.�������������;
	�����������.value	= ������.�����������;
	��������.value	= ������.��������;
	�������������������.value	= ������.�������������������;
	var ���� = new Date();
	�����.innerText = (���� - �����);
	����� = false;
}
