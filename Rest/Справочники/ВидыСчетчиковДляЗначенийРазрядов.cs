
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/VidySchetchikovDlyaZnachenijjRazryadov")]
	[Route("/Catalogs/VidySchetchikovDlyaZnachenijjRazryadov/{Code}")]
	public class VidySchetchikovDlyaZnachenijjRazryadovRequest/*��������������������������������������*/: V82.�����������������.��������������������������������,IReturn<VidySchetchikovDlyaZnachenijjRazryadovRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class VidySchetchikovDlyaZnachenijjRazryadovResponse//�������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/VidySchetchikovDlyaZnachenijjRazryadovs")]
	[Route("/Catalogs/VidySchetchikovDlyaZnachenijjRazryadovs/{Codes}")]
	public class VidySchetchikovDlyaZnachenijjRazryadovsRequest/*��������������������������������������*/: IReturn<List<VidySchetchikovDlyaZnachenijjRazryadovRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public VidySchetchikovDlyaZnachenijjRazryadovsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class VidySchetchikovDlyaZnachenijjRazryadovsResponse//�������������������������������������
	{
		public string Result {get;set;}
	}


	public class VidySchetchikovDlyaZnachenijjRazryadovService /*��������������������������������������*/ : Service
	{
		public object Any(VidySchetchikovDlyaZnachenijjRazryadovRequest request)
		{
			return new VidySchetchikovDlyaZnachenijjRazryadovResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(VidySchetchikovDlyaZnachenijjRazryadovRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������������������.�����������(���������);
				if (������ == null)
				{
					return new VidySchetchikovDlyaZnachenijjRazryadovResponse() {Result = "�������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������������������.�����������(1);
			}
		}

		public object Get(VidySchetchikovDlyaZnachenijjRazryadovsRequest request)
		{
			var ��������� = new List<V82.�����������������.��������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.��������������������������������.�����������(���������);
					if (������ != null)
					{
						���������.Add(������);
					}
				}
			}
			return ���������;
		}

	}
}
