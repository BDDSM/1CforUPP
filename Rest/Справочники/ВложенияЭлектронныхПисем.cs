
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/VlozheniyaEHlektronnykhPisem")]
	[Route("/Catalogs/VlozheniyaEHlektronnykhPisem/{Code}")]
	public class VlozheniyaEHlektronnykhPisemRequest/*������������������������������*/: V82.�����������������.������������������������,IReturn<VlozheniyaEHlektronnykhPisemRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class VlozheniyaEHlektronnykhPisemResponse//�����������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/VlozheniyaEHlektronnykhPisems")]
	[Route("/Catalogs/VlozheniyaEHlektronnykhPisems/{Codes}")]
	public class VlozheniyaEHlektronnykhPisemsRequest/*������������������������������*/: IReturn<List<VlozheniyaEHlektronnykhPisemRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public VlozheniyaEHlektronnykhPisemsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class VlozheniyaEHlektronnykhPisemsResponse//�����������������������������
	{
		public string Result {get;set;}
	}


	public class VlozheniyaEHlektronnykhPisemService /*������������������������������*/ : Service
	{
		public object Any(VlozheniyaEHlektronnykhPisemRequest request)
		{
			return new VlozheniyaEHlektronnykhPisemResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(VlozheniyaEHlektronnykhPisemRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������������������.�����������(���������);
				if (������ == null)
				{
					return new VlozheniyaEHlektronnykhPisemResponse() {Result = "������������������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������������������.�����������(1);
			}
		}

		public object Get(VlozheniyaEHlektronnykhPisemsRequest request)
		{
			var ��������� = new List<V82.�����������������.������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.������������������������.�����������(���������);
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
