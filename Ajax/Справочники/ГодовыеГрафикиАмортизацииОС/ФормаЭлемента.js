
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
	���.value	= ������.���;
	������������.value	= ������.������������;
	�����������.value	= ������.�����������;
	�����������1.value	= ������.�����������1;
	�����������2.value	= ������.�����������2;
	�����������3.value	= ������.�����������3;
	�����������4.value	= ������.�����������4;
	�����������5.value	= ������.�����������5;
	�����������6.value	= ������.�����������6;
	�����������7.value	= ������.�����������7;
	�����������8.value	= ������.�����������8;
	�����������9.value	= ������.�����������9;
	�����������10.value	= ������.�����������10;
	�����������11.value	= ������.�����������11;
	�����������12.value	= ������.�����������12;
	var ���� = new Date();
	�����.innerText = (���� - �����);
	����� = false;
}
