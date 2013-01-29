
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/RazdelyAnkety")]
	[Route("/Catalogs/RazdelyAnkety/{Code}")]
	public class RazdelyAnketyRequest/*�������������������*/: V82.�����������������.�������������,IReturn<RazdelyAnketyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class RazdelyAnketyResponse//������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/RazdelyAnketys")]
	[Route("/Catalogs/RazdelyAnketys/{Codes}")]
	public class RazdelyAnketysRequest/*�������������������*/: IReturn<List<RazdelyAnketyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public RazdelyAnketysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class RazdelyAnketysResponse//������������������
	{
		public string Result {get;set;}
	}


	public class RazdelyAnketyService /*�������������������*/ : Service
	{
		public object Any(RazdelyAnketyRequest request)
		{
			return new RazdelyAnketyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(RazdelyAnketyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������.�����������(���������);
				if (������ == null)
				{
					return new RazdelyAnketyResponse() {Result = "������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������.�����������(1);
			}
		}

		public object Get(RazdelyAnketysRequest request)
		{
			var ��������� = new List<V82.�����������������.�������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�������������.�����������(���������);
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
