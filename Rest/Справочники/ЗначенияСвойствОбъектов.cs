
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/ZnacheniyaSvojjstvObektov")]
	[Route("/Catalogs/ZnacheniyaSvojjstvObektov/{Code}")]
	public class ZnacheniyaSvojjstvObektovRequest/*�����������������������������*/: V82.�����������������.�����������������������,IReturn<ZnacheniyaSvojjstvObektovRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class ZnacheniyaSvojjstvObektovResponse//����������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/ZnacheniyaSvojjstvObektovs")]
	[Route("/Catalogs/ZnacheniyaSvojjstvObektovs/{Codes}")]
	public class ZnacheniyaSvojjstvObektovsRequest/*�����������������������������*/: IReturn<List<ZnacheniyaSvojjstvObektovRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public ZnacheniyaSvojjstvObektovsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class ZnacheniyaSvojjstvObektovsResponse//����������������������������
	{
		public string Result {get;set;}
	}


	public class ZnacheniyaSvojjstvObektovService /*�����������������������������*/ : Service
	{
		public object Any(ZnacheniyaSvojjstvObektovRequest request)
		{
			return new ZnacheniyaSvojjstvObektovResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(ZnacheniyaSvojjstvObektovRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����������������������.�����������(���������);
				if (������ == null)
				{
					return new ZnacheniyaSvojjstvObektovResponse() {Result = "����������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����������������������.�����������(1);
			}
		}

		public object Get(ZnacheniyaSvojjstvObektovsRequest request)
		{
			var ��������� = new List<V82.�����������������.�����������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�����������������������.�����������(���������);
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
